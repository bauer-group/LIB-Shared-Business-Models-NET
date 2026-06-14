using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Customs / export data for a product. Extends <see cref="ERPObjectBase"/> and carries the
    /// tariff classification, customs value and descriptive texts.
    /// </summary>
    public class ERPCustoms: ERPObjectBase
    {
        /// <summary>Initialises new customs data defaulting to <see cref="ERPCurrency.EUR"/>, zero value and empty texts.</summary>
        public ERPCustoms()
        {
            TariffNumber = @"";
            Value = 0m;
            Currency = ERPCurrency.EUR;
            Text = new List<ERPProductText>(0);
        }

        /// <summary>Customs tariff number (commodity / HS code).</summary>
        public String TariffNumber { get; set; }
        /// <summary>Customs value, in <see cref="Currency"/>.</summary>
        public Decimal Value { get; set; }
        /// <summary>Currency of the customs <see cref="Value"/>.</summary>
        public ERPCurrency Currency { get; set; }
        /// <summary>Descriptive customs texts for the product.</summary>
        public List<ERPProductText> Text { get; set; }
    }
}
