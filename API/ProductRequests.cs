using Bangazon.Models;
using Bangazon.DTOs;

namespace Bangazon.API
{
    public class ProductRequests
    {
        public static void Map(WebApplication app)
        {
            // get products
            app.MapGet("/products", (BangazonDbContext db) =>
            {
                return db.Products.ToList();
            });

            // get products by id
            app.MapGet("/products/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Products.SingleOrDefault(product => product.Id == id);
            });

            // get products by seller
            app.MapGet("/products/sellers/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Products.Where(product => product.SellerId == id).ToList();
            });

            // get products by category
            app.MapGet("/products/categories/{id}", (BangazonDbContext db, int id) =>
            {
                return db.Products.Where(product => product.CategoryId == id).ToList();
            });
        }
    }
}