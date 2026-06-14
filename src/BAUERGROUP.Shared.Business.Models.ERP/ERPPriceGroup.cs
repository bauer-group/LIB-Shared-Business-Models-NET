using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A customer price group used to scope <see cref="ERPProductPrices"/> to a set of customers.
    /// Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPPriceGroup: ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty code and name.</summary>
        public ERPPriceGroup()
        {
            Code = Name = @"";
        }

        /// <summary>Short lookup code of the price group.</summary>
        public string Code { get; set; }
        /// <summary>Human-readable name of the price group.</summary>
        public string Name { get; set; }
    }
}
