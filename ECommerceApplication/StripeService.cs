
// Adaptee
public class StripeService
{
    public void MakePayment(decimal amount, string currency)
    {
        Console.WriteLine($"Payment of {amount} {currency} made using Stripe");
    }
}
