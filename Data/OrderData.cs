using Bangazon.Models;

namespace Bangazon.Data
{
    public class OrderData
    {
        public static List<Order> Orders = new()
        {
            new() { Id = 1, Uid = "4baf60286c8441269bca0f5112db", PaymentTypeId = 1, Date = DateTime.Now.AddDays(-10), Open = false },
            new() { Id = 2, Uid = "4baf60286c8441269bca0f5112db", PaymentTypeId = 2, Date = DateTime.Now.AddDays(-8), Open = false },
            new() { Id = 3, Uid = "1f6efc6bb5ec49d1aae275dc218c", PaymentTypeId = null, Date = DateTime.Now.AddDays(-6), Open = true },
            new() { Id = 4, Uid = "1f6efc6bb5ec49d1aae275dc218c", PaymentTypeId = null, Date = DateTime.Now.AddDays(-4), Open = true },
            new() { Id = 5, Uid = "bc4772dadb754b9a84ddcd50ffc6", PaymentTypeId = 3, Date = DateTime.Now.AddDays(-2), Open = false },
            new() { Id = 6, Uid = "bc4772dadb754b9a84ddcd50ffc6", PaymentTypeId = null, Date = DateTime.Now.AddDays(-1), Open = true },
            new() { Id = 7, Uid = "6ff438a599e3432cb6fc413c5d58", PaymentTypeId = null, Date = DateTime.Now.AddDays(-3), Open = true },
            new() { Id = 8, Uid = "6ff438a599e3432cb6fc413c5d58", PaymentTypeId = 2, Date = DateTime.Now, Open = false },
            new() { Id = 9, Uid = "3492dcf84a0546c1b47dbb196210 ", PaymentTypeId = 3, Date = DateTime.Now.AddDays(-5), Open = false },
            new() { Id = 10, Uid = "3492dcf84a0546c1b47dbb196210 ", PaymentTypeId = 1, Date = DateTime.Now.AddDays(-7), Open = false }
        };
    }
}