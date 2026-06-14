using System;
using System.ComponentModel;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Derived processing status of a parcel along its preparation lifecycle.
    /// </summary>
    public enum ParcelStatus
    {
        /// <summary>Created but not yet printed or dispatched.</summary>
        [Description("offen")]
        Open = 0,

        /// <summary>Label printed but no shipment number assigned yet.</summary>
        [Description("gedruckt")]
        Printed = 1,

        /// <summary>Fully processed with a shipment number assigned.</summary>
        [Description("abgeschlossen")]
        Complete = 2
    }
}
