using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class FixUserAuth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirebaseKey",
                table: "Users",
                newName: "Uid");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 18, 20, 3, 31, 533, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 20, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 22, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 24, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 26, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 27, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 25, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 8, 28, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 23, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 21, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8582));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "Users",
                newName: "FirebaseKey");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 17, 20, 5, 32, 355, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 19, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 21, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 23, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 25, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 26, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 24, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 8, 27, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 22, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 20, 20, 5, 32, 356, DateTimeKind.Local).AddTicks(7973));
        }
    }
}
