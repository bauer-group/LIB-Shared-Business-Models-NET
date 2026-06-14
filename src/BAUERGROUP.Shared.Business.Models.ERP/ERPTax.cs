using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A tax / VAT rate line for a country. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPTax : ERPObjectBase
    {
        /// <summary>Initialises a new tax line defaulting to <see cref="ERPCurrency.EUR"/> and a zero VAT rate.</summary>
        public ERPTax()
        {
            Currency = ERPCurrency.EUR;
            VAT = 0m;
            Country = new ERPCountry();
        }

        /// <summary>Currency the tax line applies to.</summary>
        public ERPCurrency Currency { get; set; }
        /// <summary>VAT rate (percentage).</summary>
        public Decimal VAT { get; set; }
        /// <summary>Country the tax rate applies to.</summary>
        public ERPCountry Country { get; set; }
    }
}
