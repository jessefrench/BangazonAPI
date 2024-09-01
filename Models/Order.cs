namespace Bangazon.Models;

public class Order
{
    public int Id { get; set; }
    public string Uid { get; set; }
    public int? PaymentTypeId { get; set; }
    public DateTime Date {  get; set; }
    public bool Open { get; set; }
    public PaymentType PaymentType { get; set; }
    public List<Product> Products { get; set; }
}