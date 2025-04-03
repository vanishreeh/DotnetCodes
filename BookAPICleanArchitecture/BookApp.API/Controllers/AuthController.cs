using BooApp.Application.Interfaces.Identity;
using BooApp.Application.Models.Identity;
using BookApp.Identity.Model;
using BookApp.Identity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IAuthService _authService;
        //AuthService authService = new AuthService();
        readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtSettings _jwtSettings;

        public AuthController(IAuthService authService,UserManager<ApplicationUser> userManager, IOptions<JwtSettings> jwtSettings)
        {
            _authService = authService;
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;

        }
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>>Login(AuthRequest authRequest)
        {
           var response= await _authService.Login(authRequest);
            return Ok(response);
        }
        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
        {
            var response = await _authService.Register(request);
            return Ok(response);
        }
        [HttpPost("refresh-token")]
        public async Task<ActionResult<RequestToken>> RefreshToken([FromBody] string refreshToken)
        {
            var response = await _authService.RefreshToken(refreshToken);
            return Ok(response);
        }
      


    }
}
