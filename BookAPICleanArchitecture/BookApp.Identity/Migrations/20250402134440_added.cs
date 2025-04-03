using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApp.Identity.Migrations
{
    /// <inheritdoc />
    public partial class added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "7c64c213-1541-4211-8b23-26e1dff7ee5a", "AQAAAAIAAYagAAAAEOKgnS0aHiLC8xBdEPUVCyYqgl6mHFEquwg12d+XVqAQCzRYzagDMZN+56iVnLJBXQ==", "abcd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f1745144-ffb2-4ad1-afa9-3c4f68e010fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "75d567f8-7d90-4c85-85c6-cb8ed3c6b836", "AQAAAAIAAYagAAAAENs7Rgj6WXjPs45kTUXP/cEEVQt7i/cXACD+qN0xGSs2tfJiZnGUPfKsqbKJ7IKAwA==", "xyze", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ceeec3bf-a5d3-479e-8e6b-d8b7b50a17fa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e417e6d3-61cd-46f8-9be9-9ff37d6e8297", "AQAAAAIAAYagAAAAEMnKYWNO2OgeMDbsAYR5ddMTCFbHM4swG0WxIPPhw7QT0ZGjMwwLKSauswumNo1+5Q==", "13395300-1a07-4f33-954d-f85d16d51933" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e22c53f3-72c5-4e7c-b240-3ccb4ecd21e6", "AQAAAAIAAYagAAAAEKSLkpd5PoKq61bpH1Y6wSLjYPSkkGJ6Wko9RllIikjFMLzM/OHF9DsE50VTBBo/CQ==", "699e0e01-01dd-4dd9-aaac-47ec4f456672" });
        }
    }
}
