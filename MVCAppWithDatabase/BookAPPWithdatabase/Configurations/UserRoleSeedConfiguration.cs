﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAPPWithdatabase.Configurations
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                    UserId = "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a"
                });
        }
    }
}
