﻿using BooApp.Application.Interfaces.Identity;
using BooApp.Application.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<AuthResponse>>Login(AuthRequest authRequest)
        {
           var response= await _authService.Login(authRequest);
            return Ok(response);
        }
    }
}
