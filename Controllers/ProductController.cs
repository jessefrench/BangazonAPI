using Bangazon.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Controllers
{
    public class ProductController
    {
        public static void Map(WebApplication app)
        {
            // get all products
            app.MapGet("/products", (BangazonDbContext db) =>
            {
                return db.Products.ToList();
            });

            // get single product
            app.MapGet("/products/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Products.SingleOrDefault(product => product.Id == id);
            });

            // search products
            app.MapGet("/products/search", (BangazonDbContext db, string searchValue) =>
            {
                var searchResults = db.Products
                    .Include(product => product.Category)
                    .Where(product =>
                        product.Name.ToLower().Contains(searchValue.ToLower()) ||
                        product.ImageUrl.ToLower().Contains(searchValue.ToLower()) ||
                        (product.Category != null && product.Category.Name.ToLower().Contains(searchValue.ToLower())) ||
                        product.Price.ToString().Contains(searchValue) ||
                        product.Quantity.ToString().Contains(searchValue) ||
                        product.SellerId.ToString().Contains(searchValue)
                    )
                    .Select(product => new ProductDTO
                    {
                        Id = product.Id,
                        Name = product.Name,
                        ImageUrl = product.ImageUrl,
                        Category = product.Category != null ? product.Category.Name : null,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        SellerId = product.SellerId
                    })
                    .ToList();

                return searchResults.Any() ? Results.Ok(searchResults) : Results.StatusCode(204);
            });
        }
    }
}