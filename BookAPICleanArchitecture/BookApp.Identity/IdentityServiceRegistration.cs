using BooApp.Application.Interfaces.Identity;
using BookApp.Identity.Context;
using BookApp.Identity.Model;
using BookApp.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Identity
{
    public static class IdentityServiceRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookAppIdentityDbContext>(options =>
            
                options.UseSqlServer(configuration.GetConnectionString("BookWebAPIconnString")));
            services.AddIdentity<ApplicationUser, IdentityRole>().
                AddEntityFrameworkStores<BookAppIdentityDbContext>().AddDefaultTokenProviders();

            services.AddScoped<IAuthService, AuthService>();

            
            return services;
        }
    }
}
