using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockQuantity : ERPObjectBase
    {
        public ERPStockQuantity() :
            this(@"", 0m)
        {

        }

        public ERPStockQuantity(string sUnit, decimal dQuantity)
        {
            Unit = new ERPStockUnit(sUnit);
            Quantity = dQuantity;
        }

        //Stock Unit
        public ERPStockUnit Unit { get; set; }
        public decimal Quantity { get; set; }

        [Obsolete]
        public decimal Quantitiy { get { return Quantity; } set { Quantity = value; } }
    }
}
