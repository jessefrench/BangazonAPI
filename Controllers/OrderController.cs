using Bangazon.Models;
using Bangazon.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Bangazon.Controllers
{
    public class OrderController
    {
        public static void Map(WebApplication app)
        {
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

            // remove product from order
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

            // get order products
            app.MapGet("/orders/{id}/products", (BangazonDbContext db, int id) =>
            {
                var Order = db.Orders.Include(order => order.Products).FirstOrDefault(order => order.Id == id);
                return Order;
            });

            // get open order
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

            // complete order
            app.MapPatch("/orders/complete", async (BangazonDbContext db, CompleteOrderDTO dto) =>
            {
                var order = await db.Orders
                    .Include(o => o.Products)
                    .FirstOrDefaultAsync(o => o.Id == dto.OrderId);

                if (order == null)
                {
                    return Results.NotFound("Order not found.");
                }

                order.Open = false;
                order.PaymentTypeId = dto.PaymentTypeId;

                try
                {
                    await db.SaveChangesAsync();
                    return Results.Ok("Order completed successfully.");
                }
                catch (Exception ex)
                {
                    return Results.Problem(
                        detail: $"Internal server error: {ex.Message}",
                        statusCode: 500,
                        title: "An unexpected error occurred.");
                }
            });
        }
    }
}