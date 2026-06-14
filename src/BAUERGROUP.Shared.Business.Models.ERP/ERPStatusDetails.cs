using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStatusDetails: ERPObjectBase
    {
        public ERPStatusDetails()
        {
            Code = 0;
            Name = @"";
        }

        public short Code { get; set; }
        public string Name { get; set; }
    }
}
