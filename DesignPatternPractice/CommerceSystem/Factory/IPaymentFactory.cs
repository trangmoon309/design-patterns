using CommerceSystem.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Factory
{
    public interface IPaymentFactory
    {
        public ICurrencyFormatter CreateCurrencyFormatter();
        public ITaxCalculator CreateTaxCalculator();
        public IPaymentProcessor CreatePaymentGateway(PaymentMethod method = PaymentMethod.Paypal);
    }
}
