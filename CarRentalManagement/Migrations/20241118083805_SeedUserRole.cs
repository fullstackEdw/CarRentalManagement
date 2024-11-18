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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9008e5c6-57f3-4090-85da-77cdb1e6e9b3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGn3nNoaDB6BlvGp2hdXpMAdgyqUHp3RU47BCoGOUxJB8CwP6MTwS64tXf4BrqZu7g==", null, false, "6ae4fb8c-0777-42c6-84af-29c9f3f96ff4", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(5741), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6037), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6120), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6123), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6125), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 11, 18, 16, 38, 4, 544, DateTimeKind.Local).AddTicks(6127) });

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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(2857), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(2876), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3079), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3081), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3169), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 11, 18, 16, 33, 21, 189, DateTimeKind.Local).AddTicks(3176) });
        }
    }
}
