using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockBinLocation : ERPCodeName
    {
        public ERPStockBinLocation()
        {
            Location = null;
            Type = null;
        }

        public ERPStockLocation Location { get; set; }
        public ERPStockType Type { get; set; }
    }
}
