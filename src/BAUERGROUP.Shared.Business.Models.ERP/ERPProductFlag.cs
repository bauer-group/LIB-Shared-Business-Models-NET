using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPProductFlag
    {
        None = 0,

        HazardousGoods = 2,
        Anesthetic = 4,
        TemperatureControlled = 8
    }
}
