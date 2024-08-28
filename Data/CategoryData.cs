using Bangazon.Models;

namespace Bangazon.Data
{
    public class CategoryData
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" },
            new Category { Id = 3, Name = "Clothing" },
            new Category { Id = 4, Name = "Home & Garden" },
            new Category { Id = 5, Name = "Toys" }
        };
    }
}