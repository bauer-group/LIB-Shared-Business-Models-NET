using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPriceGroup: ERPObjectBase
    {
        public ERPPriceGroup()
        {
            Code = Name = @"";
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }
}
