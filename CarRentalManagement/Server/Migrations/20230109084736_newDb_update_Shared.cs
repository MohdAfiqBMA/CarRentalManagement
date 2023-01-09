using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newDb_update_Shared : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "03266334-b7e1-400c-88cb-c712737c174f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "10b9e8d0-3b33-4f42-85db-db591b188d41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bd0f42-f85e-45e4-87c2-c6d6d6a94b49", "AQAAAAEAACcQAAAAEFep/CQ5UOnrndWwDtpBNMR6oblzbQRX7X4A3+sSt3JKTBsRxExU0o4SZ6ftWZXUQw==", "0894ad63-512f-4c77-92f0-f14366042680" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 965, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 1, 9, 16, 47, 35, 966, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 966, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 1, 9, 16, 47, 35, 966, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 1, 9, 16, 47, 35, 968, DateTimeKind.Local).AddTicks(6048) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "3340e1ac-e458-4e85-ab9b-6593fa409bd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "e62494b3-e01b-420d-bdd1-79267f38b68b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60162323-8555-4bde-83a4-25c7faca9015", "AQAAAAEAACcQAAAAEF2RlY5AbS5u9Y+S1qkCk/6NV9OOSJY109Ime2tywYxxVL700GhOH4CQ104Orun1hQ==", "c1fdaad5-10c9-480c-9284-3440801a147a" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 847, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 1, 9, 16, 41, 25, 848, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 848, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 1, 9, 16, 41, 25, 848, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(5245), new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 1, 9, 16, 41, 25, 849, DateTimeKind.Local).AddTicks(8964) });
        }
    }
}
