using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A node in a <see cref="ERPStockCollection"/> tree, carrying a bin location and its
    /// child nodes.
    /// </summary>
    public class ERPStockCollectionItem
    {
        /// <summary>Initialises a new node with an empty child list and no data.</summary>
        public ERPStockCollectionItem()
        {
            Children = new List<ERPStockCollectionItem>(0);
            Data = null;
        }

        /// <summary>Child nodes nested under this item.</summary>
        public List<ERPStockCollectionItem> Children { get; set; }
        /// <summary>Bin location carried by this node (<c>null</c> if not set).</summary>
        public ERPStockBinLocation Data { get; set; }
    }
}
