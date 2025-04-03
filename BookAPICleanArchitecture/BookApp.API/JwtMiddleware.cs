using BooApp.Application.Interfaces.Identity;
using BooApp.Application.Models.Identity;
using BookApp.Identity.Model;
using BookApp.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace BookApp.API
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly JwtSettings _jwtSettings;
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IAuthService _authService; 
        //using ScopeFactory to inject scoped dependencies, because middle is singleton by default and userManager and auth are scoped services
        private readonly IServiceScopeFactory _scopeFactory;

        public JwtMiddleware(RequestDelegate next, IOptions<JwtSettings> jwtSettings, IServiceScopeFactory scopeFactory )
        {
            _next = next;
            _jwtSettings = jwtSettings.Value;
            _scopeFactory = scopeFactory;
             
       // _userManager = userManager;
           // _authService = authService;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (!string.IsNullOrEmpty(token))
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_jwtSettings.Key);

                try
                {
                    var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true //  Reject expired tokens
                    }, out SecurityToken validatedToken);

                    // Attach user to context
                    var userId = principal.FindFirst("uid")?.Value;
                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var _userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                        var _authService = scope.ServiceProvider.GetRequiredService<IAuthService>();

                        var user = await _userManager.FindByIdAsync(userId);
                        if (user != null)
                        {
                            context.Items["User"] = user;
                        }
                    }
                }
                catch (SecurityTokenExpiredException)
                {
                    await HandleExpiredToken(context, token);
                    return;
                }
                catch
                {
                    context.Response.StatusCode = 401; // Unauthorized
                    return;
                }
            }

            await _next(context);
        }

        private async Task HandleExpiredToken(HttpContext context, string expiredToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(expiredToken);
            var userId = jwtToken.Claims.FirstOrDefault(c => c.Type == "uid")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                context.Response.StatusCode = 401; // Unauthorized
                return;
            }

            using (var scope = _scopeFactory.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var authService = scope.ServiceProvider.GetRequiredService<IAuthService>();

                var user = await userManager.FindByIdAsync(userId);
                if (user == null || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
                {
                    context.Response.StatusCode = 401; // Unauthorized
                    return;
                }

                // Generate a new access token and refresh token
                var newJwtToken = await authService.GenerateToken(user);
                var newRefreshToken = GenerateRefreshToken();
                Console.WriteLine($"New Token: {newJwtToken}");
                Console.WriteLine($"New Refresh Token: {newRefreshToken}");
                // Update user's refresh token in database
                user.RefreshToken = newRefreshToken;
                user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
                await userManager.UpdateAsync(user);

                // Attach new tokens in the response headers
                context.Response.Headers["X-New-Token"] = new JwtSecurityTokenHandler().WriteToken(newJwtToken);
                context.Response.Headers["X-New-Refresh-Token"] = newRefreshToken;

            }
            // Allow the request to continue
            await _next(context);
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
#region old code with validateLifeTimeAs False
//    public class JwtMiddleware
//    {
//        private readonly RequestDelegate _next;
//        private readonly JwtSettings _jwtSettings;
//        private readonly UserManager<ApplicationUser> _userManager;

//        public JwtMiddleware(RequestDelegate next, JwtSettings jwtSettings, UserManager<ApplicationUser> userManager)
//        {
//            _next = next;
//            _jwtSettings = jwtSettings;
//            _userManager = userManager;
//        }

//        public async Task Invoke(HttpContext context,IAuthService authService)
//        {
//            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
//           
//            if (!string.IsNullOrEmpty(token))
//            {
//                var tokenHandler = new JwtSecurityTokenHandler();
//                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
//                {
//                    ValidateIssuerSigningKey = true,
//                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
//                    ValidateIssuer = false,
//                    ValidateAudience = false,
//                    ValidateLifetime = true 
//                }, out SecurityToken validatedToken);

//                if (validatedToken is JwtSecurityToken jwtSecurityToken)
//                {
//                    var userId = principal.FindFirst("uid")?.Value;
//                    var user = await _userManager.FindByIdAsync(userId);

//                    if (user != null && user.RefreshTokenExpiryTime > DateTime.UtcNow)
//                    {
//                        var newToken = await authService.GenerateToken(user);
//                        context.Response.Headers["X-New-Token"] = new JwtSecurityTokenHandler().WriteToken(newToken);
//                    }
//                }
//            }

//            await _next(context);
//        }
//    }
//    //add a logic to reject expired Token ---throw unauthorized expection
//    //In frontend, call your API RefreshTokenToken Method
//or verify in the backend only

//}
#endregion




