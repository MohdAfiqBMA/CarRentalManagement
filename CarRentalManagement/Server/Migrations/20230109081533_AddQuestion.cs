using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class AddQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "dfd2ff0c-8606-4732-8bf7-225ac79bc407");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ac28e3ea-4971-4dba-bd4c-ff5639d1038d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b0d3dae-add9-473c-8064-f5673d6eecdc", "AQAAAAEAACcQAAAAEEDpycu0PfeK4bcpKv/6r+Nxw+AwBtyA4zlHZfZCG8eOfW8gZWMD+KJp/CXdQVF5dQ==", "dc07ec54-1e8d-4557-afc2-d4bd1fec6720" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 532, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 1, 9, 16, 15, 32, 533, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 533, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 1, 9, 16, 15, 32, 533, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9822), new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 1, 9, 16, 15, 32, 536, DateTimeKind.Local).AddTicks(9827) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "3d33fc23-f42c-4dfa-a906-8b9b9d8f92f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "a896a7d7-34f0-4b35-b939-7be0a888da1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0bf4833-d45a-4612-bf6f-73fb45aea039", "AQAAAAEAACcQAAAAEF+EtzvYCdOD37lRt6mdjb/C3bm/U2nPqhjZU4nckS8BjIVYZKYNZpJxtHsSXnCqhA==", "6d6cf987-5bbc-42b6-89f9-a13e4a77e8ba" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 303, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 1, 8, 0, 47, 14, 304, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 304, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 1, 8, 0, 47, 14, 304, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 1, 8, 0, 47, 14, 305, DateTimeKind.Local).AddTicks(9702) });
        }
    }
}
