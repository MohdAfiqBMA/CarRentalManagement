using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newDb_update_questionmark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "64ee2959-2976-4bb4-b89d-4b8c3d00f2dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "6b3abf14-2b47-47ab-a413-7f7b12550875");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69b9ec4c-9d84-4462-b395-a1ffea112977", "AQAAAAEAACcQAAAAEAEXrg0J/oN/EeuOE5ULm5v+vzkT3+ikWm0pFs6IBrdG7UogJPOQpxaBEatVF0ygWQ==", "307c5703-5952-42b7-a892-7cec8f4b17f8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 16, DateTimeKind.Local).AddTicks(4648), new DateTime(2023, 1, 9, 16, 29, 27, 17, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 17, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 1, 9, 16, 29, 27, 17, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 18, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 1, 9, 16, 29, 27, 18, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 18, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 1, 9, 16, 29, 27, 18, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3709), new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3719), new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3724), new DateTime(2023, 1, 9, 16, 29, 27, 19, DateTimeKind.Local).AddTicks(3725) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
