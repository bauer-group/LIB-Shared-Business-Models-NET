using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A single price tier for a product: the price for a given quantity, with validity window,
    /// discounting rules, taxes, applicable countries and currency. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPProductPrices: ERPObjectBase
    {
        /// <summary>Initialises a new instance with neutral defaults (quantity 1, price 0, discountable, EUR, unbounded validity).</summary>
        public ERPProductPrices()
        {
            Quantity = 1m;
            Price = 0m;

            Discountable = true;
            Rebate = 0m;

            // ValidFrom/ValidTo null => unbounded validity (was Itenso TimeRange.Anytime).

            PartnerReference = null;

            PriceGroup = null;

            Taxes = new List<ERPTax>(0);
            Countries = new List<ERPCountry>(0);

            Currency = ERPCurrency.EUR;
        }

        /// <summary>Quantity threshold from which this price applies, expressed in the product's unit.</summary>
        public Decimal Quantity { get; set; }
        /// <summary>Unit price for the tier, in <see cref="Currency"/>.</summary>
        public Decimal Price { get; set; }

        /// <summary>Whether this price may receive further discounts.</summary>
        public Boolean Discountable { get; set; }
        /// <summary>Rebate applied to this price (percentage or amount as used by the consumer).</summary>
        public decimal Rebate { get; set; }

        /// <summary>Start of the validity window (<c>null</c> = unbounded / valid from any time).</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>End of the validity window (<c>null</c> = unbounded / valid until any time).</summary>
        public DateTime? ValidTo { get; set; }

        /// <summary>Partner article reference this price is tied to (<c>null</c> if none).</summary>
        public ERPProductPartnersReference PartnerReference { get; set; }

        /// <summary>Customer price group this price applies to (<c>null</c> = all groups).</summary>
        public ERPPriceGroup PriceGroup { get; set; }

        /// <summary>Taxes applicable to this price.</summary>
        public List<ERPTax> Taxes { get; set; }
        /// <summary>Countries in which this price applies.</summary>
        public List<ERPCountry> Countries { get; set; }

        /// <summary>Currency in which <see cref="Price"/> is expressed.</summary>
        public ERPCurrency Currency { get; set; }
    }
}
