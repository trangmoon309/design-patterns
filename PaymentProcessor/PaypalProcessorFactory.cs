using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    public class PaypalProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            var paypalFactory = new PaypalProcessor();

            return paypalFactory;
        }
    }
}
