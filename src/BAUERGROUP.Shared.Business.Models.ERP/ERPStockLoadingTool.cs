using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

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
