using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6262), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6531), new DateTime(2024, 11, 20, 11, 48, 28, 280, DateTimeKind.Local).AddTicks(6532) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(6916), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7157), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7160), new DateTime(2024, 11, 18, 21, 21, 14, 655, DateTimeKind.Local).AddTicks(7161) });
        }
    }
}
