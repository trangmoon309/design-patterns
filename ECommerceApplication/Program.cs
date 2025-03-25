class Program
{
    static void Main()
    {
        // Use PayPal
        IPaymentProcessor payPalProcessor = new PaypalProcessor();
        PaymentService paymentService = new PaymentService(payPalProcessor);
        paymentService.Checkout(100, "USD");

        // Switch to Stripe
        IPaymentProcessor stripeProcessor = new StripeProcessorApdater();
        paymentService = new PaymentService(stripeProcessor);
        paymentService.Checkout(200, "EUR");
    }
}
