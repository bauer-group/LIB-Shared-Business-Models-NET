using System;
using BAUERGROUP.Shared.Business.Models.ERP.Exceptions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPCurrencyExtensions
    {
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
