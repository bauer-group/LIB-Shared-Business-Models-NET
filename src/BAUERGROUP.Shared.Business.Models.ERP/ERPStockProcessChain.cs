using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockProcessChain : ERPCodeName
    {
        public ERPStockProcessChain()
        {
            Steps = new Dictionary<ERPStockProcessStep, ERPStockBinLocation>(0);
        }

        public Dictionary<ERPStockProcessStep, ERPStockBinLocation> Steps { get; set; }        
    }
}
