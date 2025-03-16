public interface IOrderBuilder
{
    IOrderBuilder SetOrderId(int orderId);
    IOrderBuilder SetStatus(string status);
    IOrderBuilder SetOrderDate(string date);
    IOrderBuilder SetCustomer(string name, string email);
    IOrderBuilder SetShippingAddress(string street, string city, string zip);
    IOrderBuilder AddProduct(int productId, string name, int quantity, decimal price);

    // Using object initializer syntax
    IOrderBuilder AddProduct(Product product);
    IOrderBuilder SetCustomer(CustomerInfo customer);
    IOrderBuilder SetShippingAddress(Address address);

    // Using delegate
    IOrderBuilder AddProduct(Action<Product> buildProduct);
    IOrderBuilder SetCustomer(Action<CustomerInfo> buildCustomer);
    IOrderBuilder SetShippingAddress(Action<Address> buildAddress);
    OrderResponse Build();
}
