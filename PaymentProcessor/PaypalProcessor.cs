using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    public class PaypalProcessor : IPaymentProcessor
    {
        public void Process(decimal amount)
        {
            Console.WriteLine($"Processing payment with Paypal for amount {amount}");
        }
    }
}
