using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockItem : ERPProduct
    {
        public ERPStockItem()
        {
            StockLabeling = new ERPStockUnitIdentification();
        }

        //Stock Unit
        public ERPStockUnitIdentification StockLabeling { get; set; }
    }
}
