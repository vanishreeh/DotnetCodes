using BookApp.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Identity.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    FirstName = "Admin",
                    LastName = "system",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin@123")

                },
                 new ApplicationUser
                 {
                     Id = "",
                     Email = "vani@gmail.com",
                     NormalizedEmail = "VANI@GMAIL.COM",
                     FirstName = "vani",
                     LastName = "shree",
                     UserName = "vani@gmail.com",
                     NormalizedUserName = "VANI@GMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "Vani@123")
                 }


                );
        }
    }
}
