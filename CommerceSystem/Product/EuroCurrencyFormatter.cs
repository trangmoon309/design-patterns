using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceSystem.Product
{
    internal class EuroCurrencyFormatter : ICurrencyFormatter
    {
        decimal ICurrencyFormatter.ConvertCurrency(
            decimal amount, 
            string fromCurrency, 
            string toCurrency)
        {
            if (fromCurrency == "EUR" && toCurrency == "USD")
            {
                return amount * 1.18m; // 1 EUR = 1.18 USD
            }
            if (fromCurrency == "USD" && toCurrency == "EUR")
            {
                return amount * 0.85m; // 1 USD = 0.85 EUR
            }
            throw new NotSupportedException(
                $"Conversion from {fromCurrency} to {toCurrency} is not supported.");
        }

        string ICurrencyFormatter.FormatCurrency(decimal amount)
        {
            return $"€{amount:N2}"; // Formats as €100,00
        }
    }
}
