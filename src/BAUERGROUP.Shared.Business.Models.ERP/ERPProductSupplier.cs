using System;

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
