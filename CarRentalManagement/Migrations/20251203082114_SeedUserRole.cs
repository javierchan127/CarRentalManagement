using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "12eca712-ef34-4c3e-be95-b743accbedac", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEC/I1DUAcIe7bieeyUgMO2phm4n2KF4CorNbsE2fdKmzAqXUzVNbFl7wyrwlthmrbg==", null, false, "8b746838-cd63-4c5d-82b3-ddb4498dc333", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(3994), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4019), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4654), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4968), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4973), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4976), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4979), new DateTime(2025, 12, 3, 16, 21, 10, 917, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(412), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(435), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(960), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(966), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1226), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1231), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1234), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1236), new DateTime(2025, 12, 3, 15, 35, 42, 907, DateTimeKind.Local).AddTicks(1237) });
        }
    }
}
