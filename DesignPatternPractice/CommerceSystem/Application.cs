using CommerceSystem.Factory;
using CommerceSystem.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem
{
    public class Application(IPaymentFactory factory)
    {
        private IPaymentProcessor paymentProcessor = factory.CreatePaymentGateway();
        private ITaxCalculator taxCalculator = factory.CreateTaxCalculator();
        private ICurrencyFormatter currencyFormatter = factory.CreateCurrencyFormatter();

        public void Run()
        {

            Console.WriteLine("Please enter the amount to pay:");
            var amount = decimal.Parse(Console.ReadLine());

            var formatedAmount = currencyFormatter
                .FormatCurrency(amount);
            Console.WriteLine($"Amount to pay in your region: {formatedAmount}");

            var taxRate = taxCalculator.GetTaxRate();
            Console.WriteLine($"Tax Rate In Your Country: {taxRate}");

            // Process payment
            PaymentResult paymentResult = paymentProcessor
                .ProcessPayment(amount, taxRate.ToString());
            Console.WriteLine($"Payment Result: {paymentResult.Message}");
        }
    }
}
