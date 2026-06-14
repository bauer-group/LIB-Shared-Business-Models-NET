using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockQuantityLimit : ERPStockQuantity
    {
        public ERPStockQuantityLimit() :
            this(ERPStockQuantityType.MinimumStock, @"", 0m)
        {

        }

        public ERPStockQuantityLimit(ERPStockQuantityType eType, string sUnit, decimal dQuantity) :
            base(sUnit, dQuantity)
        {
            Type = eType;
        }

        public ERPStockQuantityType Type { get; set; }
    }
}
