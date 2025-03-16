using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    internal class PaypalPaymentProcessor : IPaymentProcessor
    {
        PaymentResult IPaymentProcessor.ProcessPayment(decimal amount, string tax)
        {
            return new PaymentResult
            {
                IsSuccess = true,
                Message = $"Payment with {amount} and tax {tax} processed successfully via PayPal."
            };
        }
    }
}
