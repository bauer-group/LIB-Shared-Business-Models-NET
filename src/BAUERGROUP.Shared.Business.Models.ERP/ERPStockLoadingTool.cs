using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockLoadingTool : ERPCodeName
    {
        public ERPStockLoadingTool()
        {

        }

        public ERPStockLoadingTool(string sCode)
        {
            Code = sCode;
        }

        public ERPStockLoadingTool(string sCode, string sName)
        {
            Code = sCode;
            Name = sName;
        }
    }
}
