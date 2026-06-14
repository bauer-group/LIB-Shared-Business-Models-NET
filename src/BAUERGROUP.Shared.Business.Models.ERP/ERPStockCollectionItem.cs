using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockCollectionItem
    {
        public ERPStockCollectionItem()
        {
            Children = new List<ERPStockCollectionItem>(0);
            Data = null;
        }

        public List<ERPStockCollectionItem> Children { get; set; }
        public ERPStockBinLocation Data { get; set; }
    }
}
