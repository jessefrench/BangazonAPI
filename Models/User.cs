namespace Bangazon.Models;

public class User
{
	public string? FirebaseKey { get; set; }
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string Address { get; set; }
	public string City { get; set; }
	public string State { get; set; }
	public string Zip {  get; set; }
	public bool Seller { get; set; }
}