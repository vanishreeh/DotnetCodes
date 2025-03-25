﻿using BooApp.Application.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Interfaces.Identity
{
   public interface IAuthService
    {
      Task<AuthResponse>  Login(AuthRequest authRequest);
      Task<RegistrationResponse> Register(RegistrationRequest registrationRequest);
    }
}
