using System;
using System.ComponentModel;

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
