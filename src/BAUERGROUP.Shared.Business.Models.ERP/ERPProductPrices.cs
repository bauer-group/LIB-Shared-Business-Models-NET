using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductPrices: ERPObjectBase
    {
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

        public Decimal Quantity { get; set; }
        public Decimal Price { get; set; }

        public Boolean Discountable { get; set; }
        public decimal Rebate { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public ERPProductPartnersReference PartnerReference { get; set; }

        public ERPPriceGroup PriceGroup { get; set; }

        public List<ERPTax> Taxes { get; set; }
        public List<ERPCountry> Countries { get; set; }

        public ERPCurrency Currency { get; set; }
    }
}
