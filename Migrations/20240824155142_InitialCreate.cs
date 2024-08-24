using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BangazonAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Zip = table.Column<string>(type: "text", nullable: false),
                    Seller = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "integer", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Open = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Users_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Clothing" },
                    { 4, "Home & Garden" },
                    { 5, "Toys" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "City", "Email", "FirstName", "LastName", "Seller", "State", "Zip" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Anytown", "john@example.com", "John", "Doe", true, "TX", "12345" },
                    { 2, "456 Oak St", "Othertown", "jane@example.com", "Jane", "Smith", false, "CA", "67890" },
                    { 3, "789 Pine St", "Smallville", "alice@example.com", "Alice", "Johnson", true, "NY", "11223" },
                    { 4, "101 Maple St", "Largetown", "bob@example.com", "Bob", "Brown", false, "FL", "33445" },
                    { 5, "202 Birch St", "Middletown", "eve@example.com", "Eve", "Davis", true, "OH", "55667" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Date", "Open", "PaymentTypeId" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2024, 8, 18, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8837), true, null },
                    { 4, 4, new DateTime(2024, 8, 20, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8839), true, null },
                    { 7, 4, new DateTime(2024, 8, 21, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8843), true, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CustomerId", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Credit Card" },
                    { 2, 4, "PayPal" },
                    { 3, 2, "Apple Pay" },
                    { 4, 1, "Google Pay" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "OrderId", "Price", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, "A high-performance laptop.", "Laptop", null, 999.99m, 1 },
                    { 2, 1, "A latest model smartphone.", "Smartphone", null, 699.99m, 1 },
                    { 3, 2, "A bestselling fiction book.", "Fiction Book", null, 19.99m, 3 },
                    { 4, 2, "A popular cookbook.", "Cookbook", null, 24.99m, 3 },
                    { 5, 3, "Comfortable denim jeans.", "Jeans", null, 49.99m, 1 },
                    { 6, 3, "A trendy t-shirt.", "T-Shirt", null, 14.99m, 5 },
                    { 7, 4, "A comfortable sofa.", "Sofa", null, 499.99m, 5 },
                    { 8, 4, "An automatic coffee maker.", "Coffee Maker", null, 89.99m, 1 },
                    { 9, 5, "A collectible action figure.", "Action Figure", null, 29.99m, 3 },
                    { 10, 5, "A fun board game.", "Board Game", null, 39.99m, 1 },
                    { 11, 1, "A powerful tablet.", "Tablet", null, 499.99m, 3 },
                    { 12, 1, "A smartwatch with various features.", "Smartwatch", null, 199.99m, 1 },
                    { 13, 2, "An insightful non-fiction book.", "Non-fiction Book", null, 22.99m, 5 },
                    { 14, 3, "A warm jacket.", "Jacket", null, 89.99m, 3 },
                    { 15, 4, "A powerful microwave oven.", "Microwave", null, 149.99m, 1 },
                    { 16, 4, "A high-speed blender.", "Blender", null, 59.99m, 5 },
                    { 17, 5, "A challenging puzzle.", "Puzzle", null, 19.99m, 3 },
                    { 18, 5, "A toy car for kids.", "Toy Car", null, 14.99m, 5 },
                    { 19, 2, "A detailed history book.", "History Book", null, 29.99m, 1 },
                    { 20, 3, "Comfortable running sneakers.", "Sneakers", null, 79.99m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "Date", "Open", "PaymentTypeId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 8, 14, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8787), false, 1 },
                    { 2, 4, new DateTime(2024, 8, 16, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8835), false, 2 },
                    { 5, 2, new DateTime(2024, 8, 22, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8840), false, 3 },
                    { 6, 2, new DateTime(2024, 8, 23, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8842), true, 1 },
                    { 8, 4, new DateTime(2024, 8, 24, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8845), false, 2 },
                    { 9, 2, new DateTime(2024, 8, 19, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8846), false, 3 },
                    { 10, 2, new DateTime(2024, 8, 17, 10, 51, 42, 845, DateTimeKind.Local).AddTicks(8848), false, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentTypeId",
                table: "Orders",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_CustomerId",
                table: "PaymentTypes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
