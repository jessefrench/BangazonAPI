using Microsoft.EntityFrameworkCore;
using Bangazon.Models;
using System.Runtime.CompilerServices;

public class BangazonDbContext : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PaymentType> PaymentTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(order => order.Products)
            .WithMany(products => products.Orders)
            .UsingEntity(x => x.ToTable("OrderItem"));

        modelBuilder.Entity<Category>().HasData(new Category[]
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" },
            new Category { Id = 3, Name = "Clothing" },
            new Category { Id = 4, Name = "Home & Garden" },
            new Category { Id = 5, Name = "Toys" }
        });

        modelBuilder.Entity<Order>().HasData(new Order[]
        {
            new Order { Id = 1, CustomerId = 2, PaymentTypeId = 1, Date = DateTime.Now.AddDays(-10), Open = false },
            new Order { Id = 2, CustomerId = 4, PaymentTypeId = 2, Date = DateTime.Now.AddDays(-8), Open = false },
            new Order { Id = 3, CustomerId = 2, PaymentTypeId = null, Date = DateTime.Now.AddDays(-6), Open = true },
            new Order { Id = 4, CustomerId = 4, PaymentTypeId = null, Date = DateTime.Now.AddDays(-4), Open = true },
            new Order { Id = 5, CustomerId = 2, PaymentTypeId = 3, Date = DateTime.Now.AddDays(-2), Open = false },
            new Order { Id = 6, CustomerId = 2, PaymentTypeId = 1, Date = DateTime.Now.AddDays(-1), Open = true },
            new Order { Id = 7, CustomerId = 4, PaymentTypeId = null, Date = DateTime.Now.AddDays(-3), Open = true },
            new Order { Id = 8, CustomerId = 4, PaymentTypeId = 2, Date = DateTime.Now, Open = false },
            new Order { Id = 9, CustomerId = 2, PaymentTypeId = 3, Date = DateTime.Now.AddDays(-5), Open = false },
            new Order { Id = 10, CustomerId = 2, PaymentTypeId = 1, Date = DateTime.Now.AddDays(-7), Open = false }
        });

        modelBuilder.Entity<PaymentType>().HasData(new PaymentType[]
        {
            new PaymentType { Id = 1, Name = "Credit Card" },
            new PaymentType { Id = 2, Name = "PayPal" },
            new PaymentType { Id = 3, Name = "Apple Pay" },
            new PaymentType { Id = 4, Name = "Google Pay" }
        });

        modelBuilder.Entity<Product>().HasData(new Product[]
        {
            new Product { Id = 1, SellerId = 1, CategoryId = 1, Name = "Laptop", Description = "A high-performance laptop.", Price = 999.99m, ImageUrl = "https://m.media-amazon.com/images/I/71p-M3sPhhL.jpg" },
            new Product { Id = 2, SellerId = 1, CategoryId = 1, Name = "Smartphone", Description = "A latest model smartphone.", Price = 699.99m, ImageUrl = "https://m.media-amazon.com/images/I/610BUxOTRgL.jpg" },
            new Product { Id = 3, SellerId = 3, CategoryId = 2, Name = "Fiction Book", Description = "A bestselling fiction book.", Price = 19.99m, ImageUrl = "https://m.media-amazon.com/images/I/814NLq0EXUL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 4, SellerId = 3, CategoryId = 2, Name = "Cookbook", Description = "A popular cookbook.", Price = 24.99m, ImageUrl = "https://m.media-amazon.com/images/I/91dxcfnV0mL._AC_UF1000,1000_QL80_.jpg" },
            new Product { Id = 5, SellerId = 1, CategoryId = 3, Name = "Jeans", Description = "Comfortable denim jeans.", Price = 49.99m, ImageUrl = "https://m.media-amazon.com/images/I/91EwLjrLicL._AC_UY1000_.jpg" },
            new Product { Id = 6, SellerId = 5, CategoryId = 3, Name = "T-Shirt", Description = "A trendy t-shirt.", Price = 14.99m, ImageUrl = "https://m.media-amazon.com/images/I/71Xp6gETH+L._AC_UY1000_.jpg" },
            new Product { Id = 7, SellerId = 5, CategoryId = 4, Name = "Sofa", Description = "A comfortable sofa.", Price = 499.99m, ImageUrl = "https://m.media-amazon.com/images/I/81jQNSQRSgL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 8, SellerId = 1, CategoryId = 4, Name = "Coffee Maker", Description = "An automatic coffee maker.", Price = 89.99m, ImageUrl = "https://m.media-amazon.com/images/I/71LB1AbsorL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 9, SellerId = 3, CategoryId = 5, Name = "Action Figure", Description = "A collectible action figure.", Price = 29.99m, ImageUrl = "https://m.media-amazon.com/images/I/61MCob3XY8S._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 10, SellerId = 1, CategoryId = 5, Name = "Board Game", Description = "A fun board game.", Price = 39.99m, ImageUrl = "https://m.media-amazon.com/images/I/81ItkRyOaaL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 11, SellerId = 3, CategoryId = 1, Name = "Tablet", Description = "A powerful tablet.", Price = 499.99m, ImageUrl = "https://m.media-amazon.com/images/I/41vvJ47bqTL._AC_.jpg" },
            new Product { Id = 12, SellerId = 1, CategoryId = 1, Name = "Smartwatch", Description = "A smartwatch with various features.", Price = 199.99m, ImageUrl = "https://m.media-amazon.com/images/I/71s4mjiit3L._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 13, SellerId = 5, CategoryId = 2, Name = "Non-fiction Book", Description = "An insightful non-fiction book.", Price = 22.99m, ImageUrl = "https://m.media-amazon.com/images/I/61OtXMZyEzL._AC_UF1000,1000_QL80_.jpg" },
            new Product { Id = 14, SellerId = 3, CategoryId = 3, Name = "Jacket", Description = "A warm jacket.", Price = 89.99m, ImageUrl = "https://m.media-amazon.com/images/I/61ERl8U2SRL._AC_UY1000_.jpg" },
            new Product { Id = 15, SellerId = 1, CategoryId = 4, Name = "Microwave", Description = "A powerful microwave oven.", Price = 149.99m, ImageUrl = "https://m.media-amazon.com/images/I/71aywVLd8PL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 16, SellerId = 5, CategoryId = 4, Name = "Blender", Description = "A high-speed blender.", Price = 59.99m, ImageUrl = "https://m.media-amazon.com/images/I/51ZK41Ai3xL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 17, SellerId = 3, CategoryId = 5, Name = "Puzzle", Description = "A challenging puzzle.", Price = 19.99m, ImageUrl = "https://m.media-amazon.com/images/I/71Ult18YREL._AC_UF894,1000_QL80_.jpg" },
            new Product { Id = 18, SellerId = 5, CategoryId = 5, Name = "Toy Car", Description = "A toy car for kids.", Price = 14.99m, ImageUrl = "https://m.media-amazon.com/images/I/71Tc4KwjZ2S.jpg" },
            new Product { Id = 19, SellerId = 1, CategoryId = 2, Name = "History Book", Description = "A detailed history book.", Price = 29.99m, ImageUrl = "https://m.media-amazon.com/images/I/91JbbJmh11L._AC_UF1000,1000_QL80_.jpg" },
            new Product { Id = 20, SellerId = 3, CategoryId = 3, Name = "Sneakers", Description = "Comfortable running sneakers.", Price = 79.99m, ImageUrl = "https://m.media-amazon.com/images/I/71KNWunXvTS._AC_UY900_.jpg" }
        });

        modelBuilder.Entity<User>().HasData(new User[]
        {
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", Address = "123 Main St", City = "Anytown", State = "TX", Zip = "12345", Seller = true },
            new User { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", Address = "456 Oak St", City = "Othertown", State = "CA", Zip = "67890", Seller = false },
            new User { Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice@example.com", Address = "789 Pine St", City = "Smallville", State = "NY", Zip = "11223", Seller = true },
            new User { Id = 4, FirstName = "Bob", LastName = "Brown", Email = "bob@example.com", Address = "101 Maple St", City = "Largetown", State = "FL", Zip = "33445", Seller = false },
            new User { Id = 5, FirstName = "Eve", LastName = "Davis", Email = "eve@example.com", Address = "202 Birch St", City = "Middletown", State = "OH", Zip = "55667", Seller = true }
        });
    }
}