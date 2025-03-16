public class OrderResponse
{
    public int OrderId { get; set; }
    public string Status { get; set; }
    public string OrderDate { get; set; }
    public CustomerInfo Customer { get; set; }
    public Address ShippingAddress { get; set; }
    public List<Product> Products { get; set; } = new();

    public void Print()
    {
        Console.WriteLine($"Order ID: {OrderId}, Status: {Status}, Date: {OrderDate}");
        Console.WriteLine($"Customer: {Customer.Name} ({Customer.Email})");
        Console.WriteLine($"Shipping Address: {ShippingAddress.Street}, {ShippingAddress.City}, {ShippingAddress.Zip}");
        Console.WriteLine("Products:");
        foreach (var product in Products)
        {
            Console.WriteLine($"  - {product.Name} (x{product.Quantity}) - ${product.Price}");
        }
    }
}

public class CustomerInfo
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
