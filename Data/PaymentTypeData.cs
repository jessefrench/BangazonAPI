using Bangazon.Models;

namespace Bangazon.Data
{
    public class PaymentTypeData
    {
        public static List<PaymentType> PaymentTypes = new()
        {
            new() { Id = 1, Name = "Credit Card" },
            new() { Id = 2, Name = "PayPal" },
            new() { Id = 3, Name = "Apple Pay" },
            new() { Id = 4, Name = "Google Pay" }
        };
    }
}