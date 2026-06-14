using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Groups a tree of stock entries. Extends <see cref="ERPObjectBase"/> and holds the
    /// top-level <see cref="ERPStockCollectionItem"/> nodes.
    /// </summary>
    public class ERPStockCollection: ERPObjectBase
    {
        /// <summary>Initialises a new collection with an empty item list.</summary>
        public ERPStockCollection()
        {
            Data = new List<ERPStockCollectionItem>(0);
        }

        /// <summary>Top-level items of the collection.</summary>
        public List<ERPStockCollectionItem> Data { get; set; }
    }
}
