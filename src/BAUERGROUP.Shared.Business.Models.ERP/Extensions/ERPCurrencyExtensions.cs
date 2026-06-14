using System;
using BAUERGROUP.Shared.Business.Models.ERP.Exceptions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPCurrency"/>.
    /// </summary>
    public static class ERPCurrencyExtensions
    {
        /// <summary>Resolves a currency string (e.g. <c>EUR</c>, <c>€</c>, <c>EURO</c>) to the matching <see cref="ERPCurrency"/>.</summary>
        /// <param name="sValue">The currency token to parse.</param>
        /// <returns>The matched <see cref="ERPCurrency"/>; currently always <see cref="ERPCurrency.EUR"/>.</returns>
        /// <exception cref="ERPArgumentNullException">Thrown when <paramref name="sValue"/> is null, empty, or whitespace.</exception>
        public static ERPCurrency ToERPCurrency(this ERPCurrency eCurrency, String sValue)
        {
            if (String.IsNullOrWhiteSpace(sValue))
                throw new ERPArgumentNullException("Currency cannot be NULL or empty.");

            switch (sValue.ToUpper())
            {
                case "EUR":
                case "€":
                case "EURO":
                    return ERPCurrency.EUR;

                default:
                    return ERPCurrency.EUR;
            }
        }
    }
}
