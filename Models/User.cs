namespace Bangazon.Models;

public class User
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string Address { get; set; }
	public string City { get; set; }
	public string State { get; set; }
	public string Zip {  get; set; }
	public bool Seller { get; set; }
	public List<Product> Products { get; set; } // if user is a seller
	public List<Order> Orders { get; set; } // if user is a customer
	public List<PaymentType> PaymentTypes { get; set; }
}