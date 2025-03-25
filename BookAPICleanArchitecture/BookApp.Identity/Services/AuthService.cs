using BooApp.Application.Exceptions;
using BooApp.Application.Interfaces.Identity;
using BooApp.Application.Models.Identity;
using BookApp.Identity.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Identity.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<ApplicationUser> _userManager;
        readonly SignInManager<ApplicationUser> _signInManger;

        //constrcutor
        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManger = signInManager;
            
        }
        public async Task<AuthResponse> Login(AuthRequest authRequest)
        {
            var user = await _userManager.FindByEmailAsync(authRequest.Email);
            if (user == null)
            {
                throw new NotFoundException($"user with Email{authRequest.Email} not exists");
            }
            var userPassword = await _signInManger.CheckPasswordSignInAsync(user, authRequest.Password, false);
            var response = new AuthResponse
            {
                Id = user.Id,
                Email=user.Email,
                UserName=user.UserName,
                Token="abcd"
                
            };
            return response;
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
               var errorResult= result.Errors.Select(e => e.Description).ToList();
                throw new BadRequestException($"{errorResult}");
            }

        }
    }
}
