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
                    { 1, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(698), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(700), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(701), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(863), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(864), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(866), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(925), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(926), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(927), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(928), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(929), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(930), new DateTime(2024, 11, 18, 11, 27, 7, 923, DateTimeKind.Local).AddTicks(931), "C-HR", "System" }
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
