using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A stocked article record. Extends <see cref="ERPProduct"/> and adds the stock-unit
    /// labelling used to identify it in the warehouse.
    /// </summary>
    public class ERPStockItem : ERPProduct
    {
        /// <summary>Initialises a new stock item with default stock-unit labelling.</summary>
        public ERPStockItem()
        {
            StockLabeling = new ERPStockUnitIdentification();
        }

        //Stock Unit
        /// <summary>Stock-unit identification / labelling of the article.</summary>
        public ERPStockUnitIdentification StockLabeling { get; set; }
    }
}
