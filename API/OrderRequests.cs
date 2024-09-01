using Bangazon.Models;
using Bangazon.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.API
{
    public class OrderRequests
    {
        public static void Map(WebApplication app)
        {
            // get orders
            app.MapGet("/orders", (BangazonDbContext db) =>
            {
                return db.Orders.Include(order => order.PaymentType).ToList();
            });

            // get order by id
            app.MapGet("/orders/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Orders.SingleOrDefault(order => order.Id == id);
            });

            // get orders by customer
            app.MapGet("/orders/customers/{uid}", (BangazonDbContext db, string uid) =>
            {
                var order = db.Orders.Where(order => order.Uid == uid).ToList();
                return order;
            });

            // get order products
            app.MapGet("/orders/{id}/products", (BangazonDbContext db, int id) =>
            {
                var Order = db.Orders.Include(order => order.Products).FirstOrDefault(order => order.Id == id);
                return Order;
            });

            // create order
            app.MapPost("/orders", (BangazonDbContext db, Order order) =>
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return Results.Created($"/orders/{order.Id}", order);
            });

            // delete order
            app.MapDelete("/orders/{id}", (BangazonDbContext db, int id) =>
            {
                var order = db.Orders.SingleOrDefault(order => order.Id == id);

                if (order == null)
                {
                    return Results.NotFound();
                }

                db.Orders.Remove(order);
                db.SaveChanges();
                return Results.NoContent();
            });

            // add product to order
            app.MapPost("/orders/add-product", (BangazonDbContext db, AddProductDTO newProduct) =>
            {
                var order = db.Orders.Include(order => order.Products).FirstOrDefault(order => order.Id == newProduct.OrderId);
                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                var product = db.Products.Find(newProduct.ProductId);
                if (product == null)
                {
                    return Results.NotFound("Product not found.");
                }

                var existingProduct = order.Products.FirstOrDefault(product => product.Id == newProduct.ProductId);
                if (existingProduct != null)
                {
                    existingProduct.Quantity += newProduct.Quantity;
                }
                else
                {
                    product.Quantity = newProduct.Quantity;
                    order.Products.Add(product);
                }

                db.SaveChanges();
                return Results.Created($"/orders/add-product", newProduct);
            });

            // delete product from order
            app.MapDelete("/orders/{orderId}/products/{productId}", (BangazonDbContext db, int orderId, int productId) =>
            {
                var order = db.Orders.Include(order => order.Products).FirstOrDefault(order => order.Id == orderId);
                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                var productToRemove = order.Products.FirstOrDefault(product => product.Id == productId);
                if (productToRemove == null)
                {
                    return Results.NotFound("Product not found in cart.");
                }

                order.Products.Remove(productToRemove);
                db.SaveChanges();
                return Results.Ok("Product removed from cart.");
            });
        }
    }
}