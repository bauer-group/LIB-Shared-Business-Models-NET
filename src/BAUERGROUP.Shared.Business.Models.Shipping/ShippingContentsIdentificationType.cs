using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Kind of identifier carried by a <see cref="ShippingContentsIdentification"/> value.
    /// </summary>
    public enum ShippingContentsIdentificationType
    {
        /// <summary>No identification type assigned.</summary>
        None = 0,

        /// <summary>Batch / LOT number.</summary>
        LOT = 1,
        /// <summary>Serial number.</summary>
        Serial = 2,

        /// <summary>Network MAC address.</summary>
        MAC = 100,
        /// <summary>Mobile-device IMEI.</summary>
        IMEI = 101,
        /// <summary>SIM card identifier (ICCID).</summary>
        SIM = 102,

        /// <summary>Universally unique identifier.</summary>
        UUID = 200,

        /// <summary>Minimum durability / best-before date.</summary>
        MinimumDurabilityDate = 300,

        /// <summary>Application-defined identifier not covered by the predefined types.</summary>
        Custom = 1000
    }
}
