using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    public interface IPaymentProcessor
    {
        PaymentResult ProcessPayment(decimal amount, string tax);
    }

    public class PaymentResult
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }
}
