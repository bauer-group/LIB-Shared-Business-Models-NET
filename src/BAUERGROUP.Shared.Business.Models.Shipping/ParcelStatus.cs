using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public enum ParcelStatus
    {
        [Description("offen")]
        Open = 0,

        [Description("gedruckt")]
        Printed = 1,

        [Description("abgeschlossen")]
        Complete = 2
    }
}
