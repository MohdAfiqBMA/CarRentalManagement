using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newDb_update_Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
