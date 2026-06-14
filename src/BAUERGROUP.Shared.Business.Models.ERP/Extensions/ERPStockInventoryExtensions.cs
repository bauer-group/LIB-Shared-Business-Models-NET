using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPStockInventoryExtensions
    {
        public static void Trim(this ERPStockInventory erpStockInventory)
        {
            erpStockInventory.TrimPublicStringProperties();

            erpStockInventory.CustomFields.Trim();

            erpStockInventory.Identification.Trim();

            erpStockInventory.Item.TrimPublicStringProperties();

            erpStockInventory.Location.TrimPublicStringProperties();            
        }

        public static void Trim(this List<ERPStockInventory> erpStockInventories)
        {
            foreach (var erpStockInventory in erpStockInventories)
                Trim(erpStockInventory);
        }
    }
}
