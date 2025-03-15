using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    internal class EnglandTaxCalculation : ITaxCalculator
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
            return 0.20m; // 20% VAT rate for England
        }
    }
}
