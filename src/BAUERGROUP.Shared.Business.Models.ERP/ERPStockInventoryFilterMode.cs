using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Selects which criteria a stock-inventory query filters on.
    /// </summary>
    public enum ERPStockInventoryFilterMode
    {
        /// <summary>No filter applied.</summary>
        None = 0,

        UID = 1,
        Reference = 2,
        Status = 3,
        /// <summary>Filter on reference and status combined.</summary>
        ReferenceANDStatus = 4,
        /// <summary>Filter on the trading partner's own reference.</summary>
        PartnersReference = 5
    }
}
