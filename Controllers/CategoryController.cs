namespace Bangazon.Controllers
{
    public class CategoryController
	{
		public static void Map(WebApplication app)
		{
			// get categories
			app.MapGet("/categories", (BangazonDbContext db) =>
			{
				return db.Categories.ToList();
			});

			// get category by id
			app.MapGet("/categories/{id}", (BangazonDbContext db, int id) =>
			{
				return db.Categories.SingleOrDefault(category => category.Id == id);
			});
		}
	}
}