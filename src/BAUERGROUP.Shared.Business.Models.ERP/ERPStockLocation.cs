using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockLocation : ERPCodeName
    {
        public ERPStockLocation()
        {
            Type = null;
        }

        public ERPStockType Type { get; set; }
    }
}
