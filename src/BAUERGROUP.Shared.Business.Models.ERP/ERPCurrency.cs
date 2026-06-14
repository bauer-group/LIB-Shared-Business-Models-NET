using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Currency reference, broadly aligned with ISO 4217 codes.
    /// </summary>
    public enum ERPCurrency
    {
        /// <summary>Non-monetary token unit (not an ISO 4217 currency).</summary>
        Tokens = -1000,

        EUR = 0,

        USD = 100
    }
}
