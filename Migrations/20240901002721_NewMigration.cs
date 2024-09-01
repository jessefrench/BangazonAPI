using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Uid",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 21, 19, 27, 21, 266, DateTimeKind.Local).AddTicks(6102), "-O5LVFGSbT2qdsa3MLZy" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7475), "-O5LVFGSbT2qdsa3MLZy" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 25, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7491), "-O5LVFGUdCWOqG1hfAEP" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7494), "-O5LVFGUdCWOqG1hfAEP" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 29, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7496), "-O5LVFGVQSk2h87zW9HB" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 30, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7499), "-O5LVFGVQSk2h87zW9HB" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 28, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7501), "-O5LVFGWgAQ6OqOvTFsQ" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7502), "-O5LVFGWgAQ6OqOvTFsQ" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 26, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7504), "-O5LVFGXDNDM1MPXFXvz" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Uid" },
                values: new object[] { new DateTime(2024, 8, 24, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7506), "-O5LVFGXDNDM1MPXFXvz" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quantity",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quantity",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quantity",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Quantity",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Quantity",
                value: 15);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Uid",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 18, 20, 3, 31, 533, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 4, new DateTime(2024, 8, 20, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 22, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 4, new DateTime(2024, 8, 24, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 26, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 27, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 4, new DateTime(2024, 8, 25, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 4, new DateTime(2024, 8, 28, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 23, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date" },
                values: new object[] { 2, new DateTime(2024, 8, 21, 20, 3, 31, 534, DateTimeKind.Local).AddTicks(8582) });
        }
    }
}
