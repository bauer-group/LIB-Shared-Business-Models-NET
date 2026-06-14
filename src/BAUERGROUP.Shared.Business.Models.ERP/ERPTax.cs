using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPTax : ERPObjectBase
    {
        public ERPTax()
        {
            Currency = ERPCurrency.EUR;
            VAT = 0m;
            Country = new ERPCountry();
        }

        public ERPCurrency Currency { get; set; }
        public Decimal VAT { get; set; }
        public ERPCountry Country { get; set; }
    }
}
