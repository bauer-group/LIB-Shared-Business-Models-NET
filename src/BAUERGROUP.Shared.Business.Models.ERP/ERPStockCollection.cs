using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockCollection: ERPObjectBase
    {
        public ERPStockCollection()
        {
            Data = new List<ERPStockCollectionItem>(0);
        }

        public List<ERPStockCollectionItem> Data { get; set; }
    }
}
