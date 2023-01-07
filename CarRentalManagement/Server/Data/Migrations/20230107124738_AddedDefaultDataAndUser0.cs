using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "ac585431-12a6-4dbb-acbf-e70d86cad4e6", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "36b534ec-2874-49b8-a941-11f4aa69cd0a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "871f123d-f0a0-45fe-ba7c-08a98029af8c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEFO9JLhjiSaPUc3W7PX+qSlfzDNsAOGIMJX66xU9Cgnybt3l+EIzKFPyKPyS9T+j8g==", null, false, "efe84ec7-58df-42ec-a4b8-54e4b344a5c6", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 7, 20, 47, 37, 564, DateTimeKind.Local).AddTicks(4935), new DateTime(2023, 1, 7, 20, 47, 37, 565, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 7, 20, 47, 37, 565, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 1, 7, 20, 47, 37, 565, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(4256), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(4260), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8037), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8041), "X5", "System" },
                    { 3, "System", new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8043), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 1, 7, 20, 47, 37, 566, DateTimeKind.Local).AddTicks(8045), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

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
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 7, 20, 36, 19, 750, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 1, 7, 20, 36, 19, 751, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 7, 20, 36, 19, 751, DateTimeKind.Local).AddTicks(6787), new DateTime(2023, 1, 7, 20, 36, 19, 751, DateTimeKind.Local).AddTicks(6801) });
        }
    }
}
