using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "d7997b1c-6895-41cd-b4c7-0adcf790ccf2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "def12525-d982-4197-8c60-c8f5715ad51d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b98b01a1-87fe-45aa-a71c-829b0508bf2c", "AQAAAAEAACcQAAAAEMARSQx5hev0YKcd06Ghg2WMVQ4ahlybt0kOSrQubMTrxH+/jAVmN0NlvwlycsC85g==", "64434d3f-7025-4d34-8299-d34dc9b68daf" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 823, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 1, 8, 0, 15, 58, 824, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 825, DateTimeKind.Local).AddTicks(639), new DateTime(2023, 1, 8, 0, 15, 58, 825, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9406), new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9416), new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9418), new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 1, 8, 0, 15, 58, 826, DateTimeKind.Local).AddTicks(9421) });
        }
    }
}
