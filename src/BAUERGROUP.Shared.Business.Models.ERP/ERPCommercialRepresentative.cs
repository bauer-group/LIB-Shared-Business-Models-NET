using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPCommercialRepresentative : ERPObjectBase
    {
        public ERPCommercialRepresentative()
        {
            Code = Name = Description = @"";
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
