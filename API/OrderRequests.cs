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
                return db.Orders.ToList();
            });

            // get order by id
            app.MapGet("/orders/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Orders.SingleOrDefault(order => order.Id == id);
            });

            // get orders by customer
            app.MapGet("/orders/customers/{id}", (BangazonDbContext db, int id) =>
            {
                var order = db.Orders.Where(order => order.CustomerId == id).ToList();
                return order;
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

            // add item to order
            app.MapPost("/orders/add-product", (BangazonDbContext db, OrderItemDTO orderItemDTO) =>
            {
                var order = db.Orders.Include(order => order.Products).SingleOrDefault(order => order.Id == orderItemDTO.OrderId);
                var product = db.Products.Find(orderItemDTO.ProductId);

                if (order == null || product == null)
                {
                    return Results.NotFound();
                }

                order.Products.Add(product);
                db.SaveChanges();
                return Results.Created($"/orders/{orderItemDTO.OrderId}/products/{orderItemDTO.ProductId}", product);
            });

            // delete item from order
            app.MapDelete("/orders/{orderId}/products/{productId}", (BangazonDbContext db, int orderId, int productId) =>
            {
                var order = db.Orders.SingleOrDefault(order => order.Id == orderId);
                var product = db.Products.SingleOrDefault(product => product.Id == productId);

                if (order == null || product == null)
                {
                    return Results.NotFound();
                }

                order.Products.Remove(product);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}