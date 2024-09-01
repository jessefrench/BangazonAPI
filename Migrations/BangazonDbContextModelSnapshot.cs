﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BangazonAPI.Migrations
{
    [DbContext(typeof(BangazonDbContext))]
    partial class BangazonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bangazon.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Home & Garden"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Toys"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Open")
                        .HasColumnType("boolean");

                    b.Property<int?>("PaymentTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 8, 21, 19, 27, 21, 266, DateTimeKind.Local).AddTicks(6102),
                            Open = false,
                            PaymentTypeId = 1,
                            Uid = "-O5LVFGSbT2qdsa3MLZy"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 8, 23, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7475),
                            Open = false,
                            PaymentTypeId = 2,
                            Uid = "-O5LVFGSbT2qdsa3MLZy"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 8, 25, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7491),
                            Open = true,
                            Uid = "-O5LVFGUdCWOqG1hfAEP"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 8, 27, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7494),
                            Open = true,
                            Uid = "-O5LVFGUdCWOqG1hfAEP"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 8, 29, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7496),
                            Open = false,
                            PaymentTypeId = 3,
                            Uid = "-O5LVFGVQSk2h87zW9HB"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 8, 30, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7499),
                            Open = true,
                            PaymentTypeId = 1,
                            Uid = "-O5LVFGVQSk2h87zW9HB"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2024, 8, 28, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7501),
                            Open = true,
                            Uid = "-O5LVFGWgAQ6OqOvTFsQ"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2024, 8, 31, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7502),
                            Open = false,
                            PaymentTypeId = 2,
                            Uid = "-O5LVFGWgAQ6OqOvTFsQ"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2024, 8, 26, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7504),
                            Open = false,
                            PaymentTypeId = 3,
                            Uid = "-O5LVFGXDNDM1MPXFXvz"
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2024, 8, 24, 19, 27, 21, 267, DateTimeKind.Local).AddTicks(7506),
                            Open = false,
                            PaymentTypeId = 1,
                            Uid = "-O5LVFGXDNDM1MPXFXvz"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Credit Card"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PayPal"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Apple Pay"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Google Pay"
                        });
                });

            modelBuilder.Entity("Bangazon.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A high-performance laptop.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71p-M3sPhhL.jpg",
                            Name = "Laptop",
                            Price = 999.99m,
                            Quantity = 10,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A latest model smartphone.",
                            ImageUrl = "https://m.media-amazon.com/images/I/610BUxOTRgL.jpg",
                            Name = "Smartphone",
                            Price = 699.99m,
                            Quantity = 20,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "A bestselling fiction book.",
                            ImageUrl = "https://m.media-amazon.com/images/I/814NLq0EXUL._AC_UF894,1000_QL80_.jpg",
                            Name = "Fiction Book",
                            Price = 19.99m,
                            Quantity = 25,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "A popular cookbook.",
                            ImageUrl = "https://m.media-amazon.com/images/I/91dxcfnV0mL._AC_UF1000,1000_QL80_.jpg",
                            Name = "Cookbook",
                            Price = 24.99m,
                            Quantity = 15,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Comfortable denim jeans.",
                            ImageUrl = "https://m.media-amazon.com/images/I/91EwLjrLicL._AC_UY1000_.jpg",
                            Name = "Jeans",
                            Price = 49.99m,
                            Quantity = 10,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "A trendy t-shirt.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71Xp6gETH+L._AC_UY1000_.jpg",
                            Name = "T-Shirt",
                            Price = 14.99m,
                            Quantity = 20,
                            SellerId = 5
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Description = "A comfortable sofa.",
                            ImageUrl = "https://m.media-amazon.com/images/I/81jQNSQRSgL._AC_UF894,1000_QL80_.jpg",
                            Name = "Sofa",
                            Price = 499.99m,
                            Quantity = 5,
                            SellerId = 5
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "An automatic coffee maker.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71LB1AbsorL._AC_UF894,1000_QL80_.jpg",
                            Name = "Coffee Maker",
                            Price = 89.99m,
                            Quantity = 15,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            Description = "A collectible action figure.",
                            ImageUrl = "https://m.media-amazon.com/images/I/61MCob3XY8S._AC_UF894,1000_QL80_.jpg",
                            Name = "Action Figure",
                            Price = 29.99m,
                            Quantity = 5,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Description = "A fun board game.",
                            ImageUrl = "https://m.media-amazon.com/images/I/81ItkRyOaaL._AC_UF894,1000_QL80_.jpg",
                            Name = "Board Game",
                            Price = 39.99m,
                            Quantity = 10,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "A powerful tablet.",
                            ImageUrl = "https://m.media-amazon.com/images/I/41vvJ47bqTL._AC_.jpg",
                            Name = "Tablet",
                            Price = 499.99m,
                            Quantity = 10,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Description = "A smartwatch with various features.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71s4mjiit3L._AC_UF894,1000_QL80_.jpg",
                            Name = "Smartwatch",
                            Price = 199.99m,
                            Quantity = 5,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "An insightful non-fiction book.",
                            ImageUrl = "https://m.media-amazon.com/images/I/61OtXMZyEzL._AC_UF1000,1000_QL80_.jpg",
                            Name = "Non-fiction Book",
                            Price = 22.99m,
                            Quantity = 20,
                            SellerId = 5
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "A warm jacket.",
                            ImageUrl = "https://m.media-amazon.com/images/I/61ERl8U2SRL._AC_UY1000_.jpg",
                            Name = "Jacket",
                            Price = 89.99m,
                            Quantity = 5,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 4,
                            Description = "A powerful microwave oven.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71aywVLd8PL._AC_UF894,1000_QL80_.jpg",
                            Name = "Microwave",
                            Price = 149.99m,
                            Quantity = 10,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            Description = "A high-speed blender.",
                            ImageUrl = "https://m.media-amazon.com/images/I/51ZK41Ai3xL._AC_UF894,1000_QL80_.jpg",
                            Name = "Blender",
                            Price = 59.99m,
                            Quantity = 15,
                            SellerId = 5
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Description = "A challenging puzzle.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71Ult18YREL._AC_UF894,1000_QL80_.jpg",
                            Name = "Puzzle",
                            Price = 19.99m,
                            Quantity = 10,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 5,
                            Description = "A toy car for kids.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71Tc4KwjZ2S.jpg",
                            Name = "Toy Car",
                            Price = 14.99m,
                            Quantity = 20,
                            SellerId = 5
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 2,
                            Description = "A detailed history book.",
                            ImageUrl = "https://m.media-amazon.com/images/I/91JbbJmh11L._AC_UF1000,1000_QL80_.jpg",
                            Name = "History Book",
                            Price = 29.99m,
                            Quantity = 10,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "Comfortable running sneakers.",
                            ImageUrl = "https://m.media-amazon.com/images/I/71KNWunXvTS._AC_UY900_.jpg",
                            Name = "Sneakers",
                            Price = 79.99m,
                            Quantity = 15,
                            SellerId = 3
                        });
                });

            modelBuilder.Entity("Bangazon.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Seller")
                        .HasColumnType("boolean");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            City = "Anytown",
                            Email = "john@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Seller = true,
                            State = "TX",
                            Uid = "-O5LVFGSbT2qdsa3MLZy",
                            Zip = "12345"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak St",
                            City = "Othertown",
                            Email = "jane@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Seller = false,
                            State = "CA",
                            Uid = "-O5LVFGUdCWOqG1hfAEP",
                            Zip = "67890"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Pine St",
                            City = "Smallville",
                            Email = "alice@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Seller = true,
                            State = "NY",
                            Uid = "-O5LVFGVQSk2h87zW9HB",
                            Zip = "11223"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Maple St",
                            City = "Largetown",
                            Email = "bob@example.com",
                            FirstName = "Bob",
                            LastName = "Brown",
                            Seller = false,
                            State = "FL",
                            Uid = "-O5LVFGWgAQ6OqOvTFsQ",
                            Zip = "33445"
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Birch St",
                            City = "Middletown",
                            Email = "eve@example.com",
                            FirstName = "Eve",
                            LastName = "Davis",
                            Seller = true,
                            State = "OH",
                            Uid = "-O5LVFGXDNDM1MPXFXvz",
                            Zip = "55667"
                        });
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderItem", (string)null);
                });

            modelBuilder.Entity("Bangazon.Models.Order", b =>
                {
                    b.HasOne("Bangazon.Models.PaymentType", "PaymentType")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentTypeId");

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("Bangazon.Models.Product", b =>
                {
                    b.HasOne("Bangazon.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("Bangazon.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bangazon.Models.PaymentType", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
