using Bangazon.Models;
using Bangazon.DTOs;

namespace Bangazon.API
{
	public class CategoryRequests
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
				var category = db.Categories.SingleOrDefault(category => category.Id == id);
				return category.Name;
			});
		}
	}
}