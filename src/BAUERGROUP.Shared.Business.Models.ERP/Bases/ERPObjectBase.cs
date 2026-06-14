using BAUERGROUP.Shared.Business.Models;
using BAUERGROUP.Shared.Business.Models.ERP.Bases.Interfaces.Bases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases
{
    public class ERPObjectBase : BusinessObject, IERPObjectBase, IBusinessObject, IBusiness
    {
        public ERPObjectBase() 
            : base()
        {
            ClientUID = Guid.Empty;
        }

        public Guid ClientUID { get; set; }
    }
}
