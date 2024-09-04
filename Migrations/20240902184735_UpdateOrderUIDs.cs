using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class UpdateOrderUIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 23, 13, 47, 35, 685, DateTimeKind.Local).AddTicks(7184), "4baf60286c8441269bca0f5112db" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 25, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9396), "4baf60286c8441269bca0f5112db" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9413), "1f6efc6bb5ec49d1aae275dc218c" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 29, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9415), "1f6efc6bb5ec49d1aae275dc218c" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 31, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9417), "bc4772dadb754b9a84ddcd50ffc6" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9421), "bc4772dadb754b9a84ddcd50ffc6" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 30, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9423), "6ff438a599e3432cb6fc413c5d58" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 9, 2, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9424), "6ff438a599e3432cb6fc413c5d58" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9426), "3492dcf84a0546c1b47dbb196210 " });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 26, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9428), "3492dcf84a0546c1b47dbb196210 " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 23, 13, 41, 31, 818, DateTimeKind.Local).AddTicks(6231), "-O5LVFGSbT2qdsa3MLZy" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 25, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6798), "-O5LVFGSbT2qdsa3MLZy" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 27, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6810), "-O5LVFGUdCWOqG1hfAEP" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 29, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6813), "-O5LVFGUdCWOqG1hfAEP" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 31, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6814), "-O5LVFGVQSk2h87zW9HB" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6819), "-O5LVFGVQSk2h87zW9HB" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 30, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6820), "-O5LVFGWgAQ6OqOvTFsQ" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 9, 2, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6822), "-O5LVFGWgAQ6OqOvTFsQ" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6823), "-O5LVFGXDNDM1MPXFXvz" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 26, 13, 41, 31, 819, DateTimeKind.Local).AddTicks(6826), "-O5LVFGXDNDM1MPXFXvz" });
        }
    }
}
