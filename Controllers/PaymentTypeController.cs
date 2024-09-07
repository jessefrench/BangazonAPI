namespace Bangazon.Controllers
{
    public class PaymentTypeController
    {
        public static void Map(WebApplication app)
        {
            // get all payment types
            app.MapGet("/payment-types", (BangazonDbContext db) =>
            {
                return db.PaymentTypes.ToList();
            });
        }
    }
}