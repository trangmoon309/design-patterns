using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    internal class AmericaTaxCalculation : ITaxCalculator
    {
        decimal ITaxCalculator.CalculateTax(decimal amount)
        {
            return amount * GetTaxRate();
        }

        decimal ITaxCalculator.GetTaxRate()
        {
            return GetTaxRate();
        }

        private decimal GetTaxRate()
        {
            return 0.07m;
        }
    }
}
