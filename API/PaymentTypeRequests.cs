using Bangazon.Models;
using Bangazon.DTOs;

namespace Bangazon.API
{
    public class PaymentTypeRequests
    {
        public static void Map(WebApplication app)
        {
            // get payment types
            app.MapGet("/paymentstypes", (BangazonDbContext db) =>
            {
                return db.PaymentTypes.ToList();
            });
        }
    }
}