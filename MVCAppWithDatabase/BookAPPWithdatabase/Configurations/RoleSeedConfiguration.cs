using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookAPPWithdatabase.Configurations
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a",
                    Name = "Administartor",
                    NormalizedName = "ADMINISTRATOR"
                },
                 new IdentityRole
                 {
                     Id = "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a",
                     Name = "User",
                     NormalizedName = "USER"
                 }
                );
        }
    }
}
