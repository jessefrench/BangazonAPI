using Bangazon.Models;

namespace Bangazon.Data
{
    public class OrderData
    {
        public static List<Order> Orders = new List<Order>
        {
            new Order { Id = 1, CustomerId = 2, PaymentTypeId = 1, Date = DateTime.Now.AddDays(-10), Open = false },
            new Order { Id = 2, CustomerId = 4, PaymentTypeId = 2, Date = DateTime.Now.AddDays(-8), Open = false },
            new Order { Id = 3, CustomerId = 2, PaymentTypeId = null, Date = DateTime.Now.AddDays(-6), Open = true },
            new Order { Id = 4, CustomerId = 4, PaymentTypeId = null, Date = DateTime.Now.AddDays(-4), Open = true },
            new Order { Id = 5, CustomerId = 2, PaymentTypeId = 3, Date = DateTime.Now.AddDays(-2), Open = false },
            new Order { Id = 6, CustomerId = 2, PaymentTypeId = 1, Date = DateTime.Now.AddDays(-1), Open = true },
            new Order { Id = 7, CustomerId = 4, PaymentTypeId = null, Date = DateTime.Now.AddDays(-3), Open = true },
            new Order { Id = 8, CustomerId = 4, PaymentTypeId = 2, Date = DateTime.Now, Open = false },
            new Order { Id = 9, CustomerId = 2, PaymentTypeId = 3, Date = DateTime.Now.AddDays(-5), Open = false },
            new Order { Id = 10, CustomerId = 2, PaymentTypeId = 1, Date = DateTime.Now.AddDays(-7), Open = false }
        };
    }
}