using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class AddFirebaseKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirebaseKey",
                table: "Users",
                type: "text",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "FirebaseKey",
                value: "-O5LVFGSbT2qdsa3MLZy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "FirebaseKey",
                value: "-O5LVFGUdCWOqG1hfAEP");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "FirebaseKey",
                value: "-O5LVFGVQSk2h87zW9HB");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "FirebaseKey",
                value: "-O5LVFGWgAQ6OqOvTFsQ");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "FirebaseKey",
                value: "-O5LVFGXDNDM1MPXFXvz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirebaseKey",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 8, 16, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 8, 18, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 8, 20, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 8, 22, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 8, 24, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 8, 25, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 8, 23, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 8, 26, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 8, 21, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 8, 19, 18, 24, 49, 693, DateTimeKind.Local).AddTicks(4654));
        }
    }
}
