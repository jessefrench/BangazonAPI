﻿namespace Bangazon.Models;

public class PaymentType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
}