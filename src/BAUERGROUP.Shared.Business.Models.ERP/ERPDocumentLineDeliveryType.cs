using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// How a single <see cref="ERPDocumentLine"/> is delivered to the recipient.
    /// </summary>
    public enum ERPDocumentLineDeliveryType
    {
        /// <summary>Delivery type not recorded.</summary>
        Unknown = 0,

        /// <summary>Delivered as a physical good.</summary>
        Physically = 10,
        /// <summary>Delivered electronically (e.g. download, licence).</summary>
        Electronic = 20,

        /// <summary>No delivery required for this line.</summary>
        NotRequired = 40,

        /// <summary>A delivery type that does not fit the predefined options.</summary>
        Other = 60,

        /// <summary>Handled internally; not delivered externally.</summary>
        Internal = 80
    }
}
