using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Coded shipping handling instructions, combining dispatch mode and insurance options.
    /// Flags enum.
    /// </summary>
    [Flags]
    public enum ERPShippingInstruction
    {
        //Shipping Instruction
        /// <summary>No shipping instruction.</summary>
        None = 0,
        /// <summary>Internal shipment (within the organisation).</summary>
        Internal = 1,

        Standard = 2,
        Express = 4,
        Cargo = 8,

        /// <summary>Requires two-person handling (heavy / bulky goods).</summary>
        TwoManHandling = 64,

        /// <summary>Customer collects the goods themselves.</summary>
        WillCollect = 128,

        /// <summary>External shipment (third party).</summary>
        External = 256,

        //Insurance Option yes/no
        /// <summary>Shipment is insured.</summary>
        Insured = 16,
        /// <summary>Shipment is not insured.</summary>
        Uninsured = 32
    }
}

//Other free Values = 192, 256, 512 ,1024, 2048, 4096, 8192, 16384, 32768, ..., All = 2147483647
