
public class OrderBuilder : IOrderBuilder
{
    private readonly OrderResponse _order = new();

    public IOrderBuilder SetOrderId(int orderId)
    {
        _order.OrderId = orderId;
        return this;
    }

    public IOrderBuilder SetStatus(string status)
    {
        _order.Status = status;
        return this;
    }

    public IOrderBuilder SetOrderDate(string date)
    {
        _order.OrderDate = date;
        return this;
    }

    public IOrderBuilder SetCustomer(string name, string email)
    {
        _order.Customer = new CustomerInfo { Name = name, Email = email };
        return this;
    }

    public IOrderBuilder SetShippingAddress(string street, string city, string zip)
    {
        _order.ShippingAddress = new Address { Street = street, City = city, Zip = zip };
        return this;
    }

    public IOrderBuilder AddProduct(int productId, string name, int quantity, decimal price)
    {
        _order.Products.Add(new Product { ProductId = productId, Name = name, Quantity = quantity, Price = price });
        return this;
    }

    public OrderResponse Build()
    {
        return _order;
    }

    
    public IOrderBuilder AddProduct(Product product)
    {
        _order.Products.Add(product);
        return this;
    }

    public IOrderBuilder SetCustomer(CustomerInfo customer)
    {
        _order.Customer = customer;
        return this;
    }

    public IOrderBuilder SetShippingAddress(Address address)
    {
        _order.ShippingAddress = address;
        return this;
    }

    public IOrderBuilder AddProduct(Action<Product> buildProduct)
    {
        var product = new Product();
        buildProduct(product);
        _order.Products.Add(product);
        return this;
    }

    public IOrderBuilder SetCustomer(Action<CustomerInfo> buildCustomer)
    {
        var customer = new CustomerInfo();
        buildCustomer(customer);
        _order.Customer = customer;
        return this;
    }

    public IOrderBuilder SetShippingAddress(Action<Address> buildAddress)
    {
        var address = new Address();
        buildAddress(address);
        _order.ShippingAddress = address;
        return this;
    }
}
