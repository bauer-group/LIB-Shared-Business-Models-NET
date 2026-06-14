using System;
using System.ComponentModel;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Processing-control state of a parcel — whether it may be handed over to the carrier.
    /// </summary>
    public enum ParcelControl
    {
        /// <summary>Cleared for shipping.</summary>
        [Description("freigegeben")]
        Released = 0,

        /// <summary>Held back and blocked from shipping.</summary>
        [Description("gesperrt")]
        Blocked = 1,

        /// <summary>Missing required data and not yet shippable.</summary>
        [Description("unvollständig")]
        Incomplete = 2
    }
}
