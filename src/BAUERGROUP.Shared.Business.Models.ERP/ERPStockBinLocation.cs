using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A bin / shelf within a <see cref="ERPStockLocation"/>. Extends <see cref="ERPCodeName"/>,
    /// so it carries a code and name, and adds the parent location and bin type.
    /// </summary>
    public class ERPStockBinLocation : ERPCodeName
    {
        /// <summary>Initialises a new bin location with neutral defaults.</summary>
        public ERPStockBinLocation()
        {
            Location = null;
            Type = null;
        }

        /// <summary>Parent warehouse / site this bin belongs to (<c>null</c> if not set).</summary>
        public ERPStockLocation Location { get; set; }
        /// <summary>Classification of the bin.</summary>
        public ERPStockType Type { get; set; }
    }
}
