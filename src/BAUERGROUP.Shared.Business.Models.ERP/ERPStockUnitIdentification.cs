using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockUnitIdentification : Dictionary<ERPStockUnit, List<ERPProductLabeling>>
    {
        public ERPStockUnitIdentification()
        {
            
        }

        public ERPStockUnitIdentification(string sUnitCode, string sCode)
        {
            Add(new ERPStockUnit(sUnitCode), new List<ERPProductLabeling>(1) { { new ERPProductLabeling(sCode) } });
        }
    }
}
