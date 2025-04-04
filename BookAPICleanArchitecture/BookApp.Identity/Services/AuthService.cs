﻿using BooApp.Application.Exceptions;
using BooApp.Application.Interfaces.Identity;
using BooApp.Application.Models.Identity;
using BookApp.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Identity.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<ApplicationUser> _userManager;
        readonly SignInManager<ApplicationUser> _signInManger;
        readonly JwtSettings _jwtSettings; 

        //constrcutor
        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,IOptions<JwtSettings> jwtSettings)
        {
            _userManager = userManager;
            _signInManger = signInManager;
            _jwtSettings = jwtSettings.Value;
            
        }
        public async Task<AuthResponse> Login(AuthRequest authRequest)
        {
            var user = await _userManager.FindByEmailAsync(authRequest.Email);
            if (user == null)
            {
                throw new NotFoundException($"user with Email{authRequest.Email} not exists");
            }
            var userPassword = await _signInManger.CheckPasswordSignInAsync(user, authRequest.Password, false);
            if (userPassword.Succeeded == false)
            {
                throw new BadRequestException($" password Credentials are wrong");
            }
          JwtSecurityToken jwtSecurityToken=  await GenerateToken(user);
            //Invoke Refresh Token
            var refreshToken = GenerateRefreshToken();
            // Store refresh token in user entity
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7); 
            await _userManager.UpdateAsync(user);
            

            // string userJwtSecurityTokenHandler = JsonConvert.SerializeObject(new { Token = response.Token, Name = response.UserName });
            var response = new AuthResponse
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                RefreshToken = refreshToken


            };
            return response;
        }
        public async Task<RequestToken> RefreshToken(string refreshToken)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.RefreshToken == refreshToken);
            if (user == null || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
                throw new UnauthorizedAccessException("Invalid or expired refresh token");

            var newJwtToken = await GenerateToken(user);
            var newRefreshToken = GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
            await _userManager.UpdateAsync(user);

            return new RequestToken
            {
                Token = new JwtSecurityTokenHandler().WriteToken(newJwtToken),
                RefreshToken = newRefreshToken
            };
        }

        public async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            //Get User Information from Db
          var userClaims=  await _userManager.GetClaimsAsync(user);
            //List of roles that user belongs To
            var roles = await _userManager.GetRolesAsync(user);
            //convert roles list into Claims
            //new Claim(claimTypes.Role,"Admin")

            var roleClaims = roles.Select(roles => new Claim(ClaimTypes.Role, roles)).ToList();
            //Create Claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim("uid",user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials

                );
            return jwtSecurityToken;
        }

        public async Task<RegistrationResponse> Register(RegistrationRequest registrationRequest)
        {
            var user = new ApplicationUser
            {
                Email = registrationRequest.Email,
                FirstName = registrationRequest.FirstName,
                LastName = registrationRequest.LastName,
                UserName = registrationRequest.Username,
                EmailConfirmed =true
            };
           var result= await _userManager.CreateAsync(user, registrationRequest.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return new RegistrationResponse() { UserId = user.Id };

            }
            else
            {
                var errorResult = string.Join(", ", result.Errors.Select(e => e.Description));
                //var errorResult= result.Errors.Select(e => e.Description).ToList();
                throw new BadRequestException($"{errorResult}");
            }

        }
        private string GenerateRefreshToken()
        {
            var randomBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }




    }
    
}
