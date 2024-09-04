using Bangazon.Models;

namespace Bangazon.Data
{
    public class UserData
    {
        public static List<User> Users = new()
        {
            new() { Uid = "4baf60286c8441269bca0f5112db", Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", Address = "123 Main St", City = "Anytown", State = "TX", Zip = "12345", Seller = true },
            new() { Uid = "1f6efc6bb5ec49d1aae275dc218c", Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", Address = "456 Oak St", City = "Othertown", State = "CA", Zip = "67890", Seller = false },
            new() { Uid = "bc4772dadb754b9a84ddcd50ffc6", Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice@example.com", Address = "789 Pine St", City = "Smallville", State = "NY", Zip = "11223", Seller = true },
            new() { Uid = "6ff438a599e3432cb6fc413c5d58", Id = 4, FirstName = "Bob", LastName = "Brown", Email = "bob@example.com", Address = "101 Maple St", City = "Largetown", State = "FL", Zip = "33445", Seller = false },
            new() { Uid = "3492dcf84a0546c1b47dbb196210", Id = 5, FirstName = "Eve", LastName = "Davis", Email = "eve@example.com", Address = "202 Birch St", City = "Middletown", State = "OH", Zip = "55667", Seller = true }
        };
    }
}