using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Text;

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
