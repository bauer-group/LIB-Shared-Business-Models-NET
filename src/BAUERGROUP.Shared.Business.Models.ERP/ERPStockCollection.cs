using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

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
