using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPRole : ERPCodeName
    {
        public ERPRole()
        {
            Members = new List<ERPEditor>(0);
        }

        public List<ERPEditor> Members { get; set; }
    }
}
