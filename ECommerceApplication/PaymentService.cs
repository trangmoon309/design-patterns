public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void Checkout(decimal amount, string currency)
    {
        bool isSuccess = _paymentProcessor.ProcessPayment(amount, currency);
        Console.WriteLine(isSuccess ? "Payment successful" : "Payment failed");
    }
}
