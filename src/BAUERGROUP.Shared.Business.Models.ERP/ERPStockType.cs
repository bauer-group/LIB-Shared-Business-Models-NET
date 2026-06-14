using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classification of a stock entry. Extends <see cref="ERPCodeName"/>,
    /// carrying a code/name identity for the stock type.
    /// </summary>
    public class ERPStockType: ERPCodeName
    {
        /// <summary>Initialises a new stock type with neutral defaults.</summary>
        public ERPStockType()
        {
            
        }
    }
}
