using System;
using System.ComponentModel;

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
