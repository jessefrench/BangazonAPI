using Microsoft.EntityFrameworkCore;
using Bangazon.Models;
using System.Runtime.CompilerServices;
using Bangazon.Data;

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
        modelBuilder.Entity<Category>().HasData(CategoryData.Categories);
        modelBuilder.Entity<Order>().HasData(OrderData.Orders);
        modelBuilder.Entity<PaymentType>().HasData(PaymentTypeData.PaymentTypes);
        modelBuilder.Entity<Product>().HasData(ProductData.Products);
        modelBuilder.Entity<User>().HasData(UserData.Users);
        
        modelBuilder.Entity<Order>()
            .HasMany(order => order.Products)
            .WithMany(products => products.Orders)
            .UsingEntity(x => x.ToTable("OrderItem"));
    }
}