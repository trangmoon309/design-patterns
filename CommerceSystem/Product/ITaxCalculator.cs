using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal amount);

        decimal GetTaxRate();
    }
}
