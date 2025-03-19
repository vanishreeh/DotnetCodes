using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAPPWithdatabase.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a", "72ce0672-a829-486b-8b0b-1a7fac7f8b85", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "9f0a0a65-56e4-4c95-a251-82445a53256e", "Administartor", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a", 0, "6c1d818c-65bd-4ea4-b94d-876d6a487999", "admin@gmail.com", false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGP7sfKoXbbitxgZHKfBjereoEGCcJtLMKd/KZF8IYUqULIYM0HtoGBr/l7hVpXW/Q==", null, false, "9a9c8cd5-ff3e-447a-a3e5-4f53a9cf1817", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - 4432 - 2879a6680b9a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a", "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1fbf - b923 - 2879a6680b9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a");
        }
    }
}
