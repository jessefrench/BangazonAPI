using Bangazon.Models;

namespace Bangazon.Data
{
    public class ProductData
    {
        public static List<Product> Products = new List<Product>
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
        };
    }
}