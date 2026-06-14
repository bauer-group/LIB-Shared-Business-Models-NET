using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

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
