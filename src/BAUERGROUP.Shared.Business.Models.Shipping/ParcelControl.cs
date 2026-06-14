using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public enum ParcelControl
    {
        [Description("freigegeben")]
        Released = 0,

        [Description("gesperrt")]
        Blocked = 1,

        [Description("unvollständig")]
        Incomplete = 2
    }
}
