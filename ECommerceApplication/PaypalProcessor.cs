public class PaypalProcessor : IPaymentProcessor
{
    private readonly PayPalService _payPalService;

    public PaypalProcessor()
    {
        _payPalService = new PayPalService(); // Assume this is PayPal’s existing SDK
    }

    public bool ProcessPayment(decimal amount, string currency)
    {
        _payPalService.MakePayment(amount, currency);

        return true;
    }
}
