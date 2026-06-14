using System;

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
