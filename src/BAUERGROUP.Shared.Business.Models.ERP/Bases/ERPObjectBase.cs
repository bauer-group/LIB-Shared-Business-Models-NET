using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases.Interfaces.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases
{
    public class ERPObjectBase : BusinessObject, IERPObjectBase, IBusinessObject, IBusiness
    {
        public ERPObjectBase()
            : base()
        {
            ClientUID = Guid.Empty;
        }

        public ERPObjectBase(Guid gUID)
            : base(gUID)
        {
            ClientUID = Guid.Empty;
        }

        public Guid ClientUID { get; set; }
    }
}
