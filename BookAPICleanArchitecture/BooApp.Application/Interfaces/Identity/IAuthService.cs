using BooApp.Application.Models.Identity;
using BookApp.Identity.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BooApp.Application.Interfaces.Identity
{
   public interface IAuthService
    {
      Task<AuthResponse>  Login(AuthRequest authRequest);
      Task<RegistrationResponse> Register(RegistrationRequest registrationRequest);
       Task<RequestToken> RefreshToken(string refreshToken);
        Task<JwtSecurityToken> GenerateToken(ApplicationUser user);
    }
}
