using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockInventory : ERPObjectBase
    {
        public ERPStockInventory()
        {
            SKU = @"";

            Location = new ERPStockBinLocation();
            Item = new ERPStockItem();
            Identification = new List<ERPProductLOTSerial>(0);
            Quantity = new List<ERPStockQuantity>(0);

            CustomFields = new List<ERPCustomField>(0);
        }

        public string SKU { get; set; } 

        public ERPStockBinLocation Location { get; set; }
        public ERPStockItem Item { get; set; }
        public List<ERPProductLOTSerial> Identification { get; set; }

        public List<ERPStockQuantity> Quantity { get; set; }

        public List<ERPCustomField> CustomFields { get; set; }
    }
}
