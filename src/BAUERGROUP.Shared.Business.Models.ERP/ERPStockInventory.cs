using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// On-hand inventory for a stock item at a bin location. Extends <see cref="ERPObjectBase"/>
    /// and ties together the item, its bin, LOT/serial identification and quantities.
    /// </summary>
    public class ERPStockInventory : ERPObjectBase
    {
        /// <summary>Initialises a new inventory record with empty collections and child objects.</summary>
        public ERPStockInventory()
        {
            SKU = @"";

            Location = new ERPStockBinLocation();
            Item = new ERPStockItem();
            Identification = new List<ERPProductLOTSerial>(0);
            Quantity = new List<ERPStockQuantity>(0);

            CustomFields = new List<ERPCustomField>(0);
        }

        /// <summary>Stock-keeping unit identifying the stocked article.</summary>
        public string SKU { get; set; }

        /// <summary>Bin / shelf where the inventory is held.</summary>
        public ERPStockBinLocation Location { get; set; }
        /// <summary>The stocked article this inventory refers to.</summary>
        public ERPStockItem Item { get; set; }
        /// <summary>LOT / serial identifiers covered by this inventory record.</summary>
        public List<ERPProductLOTSerial> Identification { get; set; }

        /// <summary>On-hand quantities, broken down by unit / quantity type.</summary>
        public List<ERPStockQuantity> Quantity { get; set; }

        /// <summary>Additional user-defined fields.</summary>
        public List<ERPCustomField> CustomFields { get; set; }
    }
}
