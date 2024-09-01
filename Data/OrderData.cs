using Bangazon.Models;

namespace Bangazon.Data
{
    public class OrderData
    {
        public static List<Order> Orders = new()
        {
            new() { Id = 1, Uid = "-O5LVFGSbT2qdsa3MLZy", PaymentTypeId = 1, Date = DateTime.Now.AddDays(-10), Open = false },
            new() { Id = 2, Uid = "-O5LVFGSbT2qdsa3MLZy", PaymentTypeId = 2, Date = DateTime.Now.AddDays(-8), Open = false },
            new() { Id = 3, Uid = "-O5LVFGUdCWOqG1hfAEP", PaymentTypeId = null, Date = DateTime.Now.AddDays(-6), Open = true },
            new() { Id = 4, Uid = "-O5LVFGUdCWOqG1hfAEP", PaymentTypeId = null, Date = DateTime.Now.AddDays(-4), Open = true },
            new() { Id = 5, Uid = "-O5LVFGVQSk2h87zW9HB", PaymentTypeId = 3, Date = DateTime.Now.AddDays(-2), Open = false },
            new() { Id = 6, Uid = "-O5LVFGVQSk2h87zW9HB", PaymentTypeId = 1, Date = DateTime.Now.AddDays(-1), Open = true },
            new() { Id = 7, Uid = "-O5LVFGWgAQ6OqOvTFsQ", PaymentTypeId = null, Date = DateTime.Now.AddDays(-3), Open = true },
            new() { Id = 8, Uid = "-O5LVFGWgAQ6OqOvTFsQ", PaymentTypeId = 2, Date = DateTime.Now, Open = false },
            new() { Id = 9, Uid = "-O5LVFGXDNDM1MPXFXvz", PaymentTypeId = 3, Date = DateTime.Now.AddDays(-5), Open = false },
            new() { Id = 10, Uid = "-O5LVFGXDNDM1MPXFXvz", PaymentTypeId = 1, Date = DateTime.Now.AddDays(-7), Open = false }
        };
    }
}