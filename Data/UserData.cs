using Bangazon.Models;

namespace Bangazon.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User { FirebaseKey = "-O5LVFGSbT2qdsa3MLZy", Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", Address = "123 Main St", City = "Anytown", State = "TX", Zip = "12345", Seller = true },
            new User { FirebaseKey = "-O5LVFGUdCWOqG1hfAEP", Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", Address = "456 Oak St", City = "Othertown", State = "CA", Zip = "67890", Seller = false },
            new User { FirebaseKey = "-O5LVFGVQSk2h87zW9HB", Id = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice@example.com", Address = "789 Pine St", City = "Smallville", State = "NY", Zip = "11223", Seller = true },
            new User { FirebaseKey = "-O5LVFGWgAQ6OqOvTFsQ", Id = 4, FirstName = "Bob", LastName = "Brown", Email = "bob@example.com", Address = "101 Maple St", City = "Largetown", State = "FL", Zip = "33445", Seller = false },
            new User { FirebaseKey = "-O5LVFGXDNDM1MPXFXvz", Id = 5, FirstName = "Eve", LastName = "Davis", Email = "eve@example.com", Address = "202 Birch St", City = "Middletown", State = "OH", Zip = "55667", Seller = true }
        };
    }
}