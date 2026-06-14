using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductPartnersReference: ERPObjectBase
    {
        public ERPProductPartnersReference()
        {
            Partner = new ERPBusinessAssociate();
            Reference = @"";
        }

        public ERPBusinessAssociate Partner { get; set; }
        public String Reference { get; set; }
    }
}
