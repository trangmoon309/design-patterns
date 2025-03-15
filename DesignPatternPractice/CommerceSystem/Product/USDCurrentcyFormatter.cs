using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    internal class USDCurrentcyFormatter : ICurrencyFormatter
    {
        decimal ICurrencyFormatter.ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "USD" && toCurrency == "EUR")
            {
                return amount * 0.85m;
            }
            throw new NotSupportedException(
                $"Conversion from {fromCurrency} to " +
                $"{toCurrency} is not supported.");
        }

        string ICurrencyFormatter.FormatCurrency(decimal amount)
        {
            return $"${amount:N2}";
        }
    }
}
