using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPObjectLinkType
    {
        None = 0,

        Forward = 10,
        Backward = 20,

        SameLevel = 30,
        Duplicate = 40,

        Depending = 50
    }
}
