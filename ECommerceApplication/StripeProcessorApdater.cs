public class StripeProcessorApdater : IPaymentProcessor
{
    // Adaptee
    private readonly StripeService _stripeService;

    public StripeProcessorApdater()
    {
        _stripeService = new StripeService(); // Assume this is Stripe’s existing SDK
    }

    public bool ProcessPayment(decimal amount, string currency)
    {
        _stripeService.MakePayment(amount, currency); // Converts interface call to Stripe-specific call

        return true;
    }
}
