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
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7504), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7507), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7585), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7585), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7587), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7588), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7590), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7591), new DateTime(2024, 11, 18, 15, 51, 4, 404, DateTimeKind.Local).AddTicks(7592), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 12, 43, 513, DateTimeKind.Local).AddTicks(1085), new DateTime(2024, 11, 18, 15, 12, 43, 513, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 12, 43, 513, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 11, 18, 15, 12, 43, 513, DateTimeKind.Local).AddTicks(1109) });
        }
    }
}
