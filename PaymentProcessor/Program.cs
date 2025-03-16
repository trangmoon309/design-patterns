// See https://aka.ms/new-console-template for more information
using PaymentProcessor;

Console.WriteLine("Please enter the amount that you want to process:");
var amount = Console.ReadLine();
Console.WriteLine("Please choose one of these payment method: Paypal, Credit Card, Stripe");
var method = Console.ReadLine();
Console.WriteLine("Payment is processing...");

IPaymentProcessorFactory factory = method.ToLower() switch
{
    "paypal" => new PaypalProcessorFactory(),
    _ => throw new ArgumentException($"Unknown payment method: {method}")
};

factory.CreatePaymentProcessor().Process(Convert.ToDecimal(amount));