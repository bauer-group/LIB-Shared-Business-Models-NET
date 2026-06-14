using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Functional role of an <see cref="ERPAddress"/> (one address may serve several roles).
    /// Bitwise-combinable (<see cref="FlagsAttribute"/>).
    /// </summary>
    [Flags]
    public enum ERPAddressType
    {
        /// <summary>Role not specified.</summary>
        Unspecified = 0,

        /// <summary>The default / primary address.</summary>
        Default = 1,

        /// <summary>Address used as the sender.</summary>
        Sender = 2,

        /// <summary>Invoicing / billing address.</summary>
        Billing = 4,
        /// <summary>Address documents are sent to.</summary>
        Documents = 8,
        /// <summary>Address goods are shipped to.</summary>
        Shipping = 16,
        /// <summary>Address used as the receiver.</summary>
        Receiver = 32,

        /// <summary>Freight forwarder / carrier address.</summary>
        Forwarder = 64,

        /// <summary>A role that does not fit the predefined types.</summary>
        Other = 256,

        /// <summary>Address used for sales contact.</summary>
        Sales = 512,
        /// <summary>Address used for marketing contact.</summary>
        Marketing = 1024
    }
}
