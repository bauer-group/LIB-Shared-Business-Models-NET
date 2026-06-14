using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
