using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(5682), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(5707), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(5712), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(5713), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6377), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6380), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6384), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6385), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6713), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6718), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6723), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6724), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6727), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6728), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 12, 3, 14, 52, 3, 788, DateTimeKind.Local).AddTicks(6732), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
