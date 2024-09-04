using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class UpdateOrderData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 23, 13, 50, 33, 31, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 25, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 27, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 29, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 31, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "PaymentTypeId" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7970), null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 30, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 9, 2, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 28, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 26, 13, 50, 33, 32, DateTimeKind.Local).AddTicks(7977));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 23, 13, 47, 35, 685, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 25, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 27, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 29, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 31, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "PaymentTypeId" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9421), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 30, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 9, 2, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 28, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 26, 13, 47, 35, 686, DateTimeKind.Local).AddTicks(9428));
        }
    }
}
