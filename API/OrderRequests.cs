using Bangazon.Models;
using Bangazon.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

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

            // get open orders by uid
            app.MapGet("/orders/open", async (BangazonDbContext db, [FromQuery] string uid) =>
            {
                var openOrder = await db.Orders
                    .Where(order => order.Uid == uid && order.Open == true)
                    .Include(order => order.PaymentType)
                    .FirstOrDefaultAsync();
                if (openOrder == null)
                {
                    return Results.Ok("No open order found for the specified user.");
                }
                return Results.Ok(openOrder);
            });

            // create order
            app.MapPost("/orders", async (BangazonDbContext db, [FromBody] Order newOrder) =>
            {
                if (newOrder == null)
                {
                    return Results.BadRequest("Invalid order data.");
                }
                newOrder.Open = true;
                db.Orders.Add(newOrder);
                await db.SaveChangesAsync();
                return Results.Created($"/orders/{newOrder.Id}", newOrder);
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
            app.MapPatch("/orders/add-product", async (BangazonDbContext db, [FromBody] AddProductDTO newProduct) =>
            {
                if (newProduct == null)
                {
                    return Results.BadRequest("Invalid product data.");
                }

                var order = await db.Orders
                    .Include(o => o.Products)
                    .FirstOrDefaultAsync(o => o.Id == newProduct.OrderId);

                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                var product = await db.Products.FindAsync(newProduct.ProductId);

                if (product == null)
                {
                    return Results.NotFound("Product not found.");
                }

                var existingProduct = order.Products.FirstOrDefault(p => p.Id == newProduct.ProductId);

                if (existingProduct != null)
                {
                    existingProduct.Quantity += newProduct.Quantity;
                }
                else
                {
                    product.Quantity = newProduct.Quantity;
                    order.Products.Add(product);
                }

                await db.SaveChangesAsync();
                return Results.NoContent();
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

            // complete an order
            app.MapPatch("/orders/complete", async (BangazonDbContext db, CompleteOrderDTO dto) =>
            {
                // Find the order by ID
                var order = await db.Orders
                    .Include(o => o.Products) // Load related products if needed
                    .FirstOrDefaultAsync(o => o.Id == dto.OrderId);

                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                // Update the order status to completed
                order.Open = false;
                order.PaymentTypeId = dto.PaymentTypeId; // Update the payment type

                try
                {
                    await db.SaveChangesAsync();
                    return Results.Ok("Order completed successfully.");
                }
                catch (Exception ex)
                {
                    // Log the error or handle it as needed
                    return Results.Problem(
                        detail: $"Internal server error: {ex.Message}",
                        statusCode: 500,
                        title: "An unexpected error occurred.");
                }
            });
        }
    }
}