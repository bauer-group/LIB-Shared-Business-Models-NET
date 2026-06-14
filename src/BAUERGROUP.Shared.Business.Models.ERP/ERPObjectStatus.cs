using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Generic lifecycle status of an ERP object, modelled as a bit flag set so that several
    /// states can be combined on a single object.
    /// </summary>
    [Flags]
    public enum ERPObjectStatus
    {
        /// <summary>No status flags set.</summary>
        None = 0,

        Obsolete = 2,
        Cancelled = 4,
        Draft = 8,
        Continued = 16,
        Disabled = 32,

        Booked = 64,

        Deleted = 128
    }
}
