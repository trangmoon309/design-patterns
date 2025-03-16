using CommerceSystem;
using CommerceSystem.Factory;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Simulate determining the customer's location (e.g., based on user input)
        Console.WriteLine("Enter your region (America/England):");
        string region = Console.ReadLine();

        // Initialize the appropriate factory based on the region
        IPaymentFactory paymentFactory = GetPaymentFactory(region);

        if (paymentFactory == null)
        {
            Console.WriteLine("Invalid region. Exiting...");
            return;
        }

        // Create and run the application
        var app = new Application(paymentFactory);
        app.Run();
    }

    // Helper method to get the appropriate factory based on the region
    private static IPaymentFactory GetPaymentFactory(string region)
    {
        switch (region.ToLower())
        {
            case "america":
                return new AmericaPaymentFactory();
            case "england":
                return new EnglandPaymentFactory();
            default:
                return null; // Unsupported region
        }
    }
}