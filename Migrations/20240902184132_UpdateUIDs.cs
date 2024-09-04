using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class UpdateUIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 23, 13, 41, 31, 818, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 25, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 27, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 29, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 31, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 9, 1, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 30, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 9, 2, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 28, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 26, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "4baf60286c8441269bca0f5112db");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "1f6efc6bb5ec49d1aae275dc218c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "bc4772dadb754b9a84ddcd50ffc6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: "6ff438a599e3432cb6fc413c5d58");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: "3492dcf84a0546c1b47dbb196210");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 23, 13, 16, 12, 477, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 25, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 27, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 29, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 31, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 9, 1, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 30, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 9, 2, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 28, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 26, 13, 16, 12, 479, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "-O5LVFGSbT2qdsa3MLZy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "-O5LVFGUdCWOqG1hfAEP");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "-O5LVFGVQSk2h87zW9HB");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: "-O5LVFGWgAQ6OqOvTFsQ");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: "-O5LVFGXDNDM1MPXFXvz");
        }
    }
}
