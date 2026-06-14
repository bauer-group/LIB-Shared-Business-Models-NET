using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{    
    /// <summary>
    /// Kind of batch/LOT or serial tracking identifier carried by an <see cref="ERPProductLOTSerial"/>.
    /// </summary>
    public enum ERPProductLOTSerialType
    {
        /// <summary>No tracking identifier.</summary>
        None = 0,

        /// <summary>Batch / LOT number.</summary>
        LOT = 1,
        /// <summary>Per-unit serial number.</summary>
        Serial = 2,

        MAC = 100,
        IMEI = 101,
        SIM = 102,

        UUID = 200,

        /// <summary>Tracked solely by a minimum durability (best-before) date.</summary>
        MinimumDurabilityDate = 300,

        /// <summary>A custom, application-defined tracking scheme.</summary>
        Custom = 1000
    }
}
