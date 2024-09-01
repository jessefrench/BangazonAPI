using Bangazon.Models;

namespace Bangazon.Data
{
    public class CategoryData
    {
        public static List<Category> Categories = new()
        {
            new() { Id = 1, Name = "Electronics" },
            new() { Id = 2, Name = "Books" },
            new() { Id = 3, Name = "Clothing" },
            new() { Id = 4, Name = "Home & Garden" },
            new() { Id = 5, Name = "Toys" }
        };
    }
}