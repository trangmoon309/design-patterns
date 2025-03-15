var builder = new OrderBuilder();

// Manually creating another order (without Director)
var customOrder = new OrderBuilder()
    .SetOrderId(67890)
    .SetStatus("Shipped")
    .SetOrderDate("2025-03-06")
    .SetCustomer("John Doe", "john@example.com")
    .SetShippingAddress("456 Elm St", "Los Angeles", "90001")
    .AddProduct(3, "Keyboard", 1, 49.99m)
    .AddProduct(4, "Monitor", 1, 199.99m)
    .Build();

customOrder.Print();
Console.WriteLine();
// Using object initializer
var order = builder
    .SetOrderId(12345)
    .SetStatus("Processing")
    .SetOrderDate("2025-03-06")
    .SetCustomer("John Doe", "john@example.com")
    .SetShippingAddress(new Address { Street = "123 Oak St", City = "Los Angeles", Zip = "90001" })
    .AddProduct(new Product { ProductId = 1, Name = "Mouse", Quantity = 1, Price = 19.99m })
    .AddProduct(new Product { ProductId = 2, Name = "Keyboard", Quantity = 1, Price = 49.99m })
    .Build();
customOrder.Print();
Console.WriteLine();

// Using deletfate
var order2 = builder
    .SetOrderId(12345)
    .SetStatus("Processing")
    .SetOrderDate("2025-03-06")
    .SetCustomer(c =>
    {
        c.Name = "John Doe";
        c.Email = "john@example.com";
    })
    .SetShippingAddress(a =>
    {
        a.Street = "123 Oak St";
        a.City = "Los Angeles";
        a.Zip = "90001";
    })
    .AddProduct(p =>
    {
        p.ProductId = 1;
        p.Name = "Mouse";
        p.Quantity = 1;
        p.Price = 19.99m;
    })
    .AddProduct(p =>
    {
        p.ProductId = 2;
        p.Name = "Keyboard";
        p.Quantity = 1;
        p.Price = 49.99m;
    })
    .Build(); 
customOrder.Print();  