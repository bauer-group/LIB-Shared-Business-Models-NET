using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Lifecycle status of an <see cref="ERPAddress"/>. Bitwise-combinable
    /// (<see cref="FlagsAttribute"/>).
    /// </summary>
    [Flags]
    public enum ERPAddressStatus
    {
        /// <summary>Address is active and usable (default).</summary>
        Active = 0,

        /// <summary>Address is temporarily disabled.</summary>
        Disabled = 2,

        /// <summary>Address is no longer current.</summary>
        Obsolete = 4,
        /// <summary>Address has passed its validity period.</summary>
        Expired = 8,

        /// <summary>Recipient has opted out of advertising/marketing contact.</summary>
        AdvertisingBan = 256
    }
}
