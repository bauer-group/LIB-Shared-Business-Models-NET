using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPStockInventory"/>.
    /// </summary>
    public static class ERPStockInventoryExtensions
    {
        /// <summary>Trims whitespace from the inventory and its custom fields, identification, item and location, in place.</summary>
        public static void Trim(this ERPStockInventory erpStockInventory)
        {
            erpStockInventory.TrimPublicStringProperties();

            erpStockInventory.CustomFields.Trim();

            erpStockInventory.Identification.Trim();

            erpStockInventory.Item.TrimPublicStringProperties();

            erpStockInventory.Location.TrimPublicStringProperties();            
        }

        /// <summary>Trims whitespace from every stock inventory in the list, in place.</summary>
        public static void Trim(this List<ERPStockInventory> erpStockInventories)
        {
            foreach (var erpStockInventory in erpStockInventories)
                Trim(erpStockInventory);
        }
    }
}
