using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductLabeling : ERPObjectBase
    {
        public ERPProductLabeling() : 
            this(@"")
        {
            
        }

        public ERPProductLabeling(string sCode, ERPProductLabelingType eType = ERPProductLabelingType.Unkown)
        {
            Type = eType;
            Code = sCode;
        }

        public ERPProductLabelingType Type { get; set; }
        public string Code { get; set; }
    }
}
