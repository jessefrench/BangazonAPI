using Bangazon.Models;

namespace Bangazon.Data
{
    public class PaymentTypeData
    {
        public static List<PaymentType> PaymentTypes = new List<PaymentType>
        {
            new PaymentType { Id = 1, Name = "Credit Card" },
            new PaymentType { Id = 2, Name = "PayPal" },
            new PaymentType { Id = 3, Name = "Apple Pay" },
            new PaymentType { Id = 4, Name = "Google Pay" }
        };
    }
}