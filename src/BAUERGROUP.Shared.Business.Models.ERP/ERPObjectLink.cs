using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPObjectLink : ERPObjectBase
    {
        public ERPObjectLink()
        {
            Type = ERPObjectLinkType.None;
            ReferralUID = Guid.Empty;
        }

        public ERPObjectLinkType Type { get; set; }
        public Guid ReferralUID { get; set; }
    }
}
