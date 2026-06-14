using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductManufacturer : ERPBusinessAssociate
    {
        public ERPProductManufacturer()
        {
            Brands = new List<ERPProductBrand>(0);
        }

        public List<ERPProductBrand> Brands { get; set; }
    }
}
