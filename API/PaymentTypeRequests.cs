using Bangazon.Models;
using Bangazon.DTOs;

namespace Bangazon.API
{
    public class PaymentTypeRequests
    {
        public static void Map(WebApplication app)
        {
            // get payment types
            app.MapGet("/payment-types", (BangazonDbContext db) =>
            {
                return db.PaymentTypes.ToList();
            });

            // get payment type by id
            app.MapGet("/payment-types/{id}", (BangazonDbContext db, int id) =>
            {
                return db.PaymentTypes.SingleOrDefault(paymentType => paymentType.Id == id);
            });
        }
    }
}