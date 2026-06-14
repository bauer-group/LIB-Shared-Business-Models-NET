using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductSupplier : ERPProductManufacturer
    {
        public ERPProductSupplier()
        {            
            Active = true;

            Prices = new List<ERPProductPrices>(0);
        }

        public Boolean Active { get; set; }

        public List<ERPProductPrices> Prices { get; set; }
    }
}
