using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    public class StripeProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"Processing payment with Stripe for amount {amount}");
        }
    }
}
