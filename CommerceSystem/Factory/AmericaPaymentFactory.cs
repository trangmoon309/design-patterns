using CommerceSystem.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Factory
{
    public class AmericaPaymentFactory : IPaymentFactory
    {
        private readonly 
            Dictionary<PaymentMethod, Func<IPaymentProcessor>> _paymentProcessors;

        public AmericaPaymentFactory()
        {
            _paymentProcessors = new 
                Dictionary<PaymentMethod, Func<IPaymentProcessor>>
            {
                { PaymentMethod.Paypal, () => new PaypalPaymentProcessor() },
                { PaymentMethod.Momo, () => new MomoPaymentProcessor() }
            };
        }

        ICurrencyFormatter IPaymentFactory.CreateCurrencyFormatter()
        {
            return new USDCurrentcyFormatter();
        }

        IPaymentProcessor IPaymentFactory.CreatePaymentGateway(PaymentMethod method)
        {
            // Avoid switch case, it do not open for extesion
            // When we add new payment method, we need to modify the factory.
            // We can use Dictionary as a simple alternative.
            // When we extend new payment, we just
            // need to add new item to the dictionary.
            //switch (method)
            //{
            //    case PaymentMethod.Momo:
            //        return new MomoPaymentProcessor();
            //    case PaymentMethod.Paypal:
            //        return new PaypalPaymentProcessor();
            //    default:
            //        return new PaypalPaymentProcessor();
            //}
            if (_paymentProcessors
                .TryGetValue(method, out var processorFactory))
            {
                return processorFactory();
            }
            throw new NotSupportedException(
                $"Payment method '{method}' is not supported in America.");
        }

        ITaxCalculator IPaymentFactory.CreateTaxCalculator()
        {
            return new AmericaTaxCalculation();
        }
    }
}
