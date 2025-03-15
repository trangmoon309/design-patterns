using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    public interface ICurrencyFormatter
    {
        string FormatCurrency(decimal amount);

        decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency);
    }
}
