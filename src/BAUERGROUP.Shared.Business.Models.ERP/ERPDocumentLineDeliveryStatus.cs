using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Fulfilment state of a single <see cref="ERPDocumentLine"/>, progressing from
    /// open through shipped/delivered.
    /// </summary>
    public enum ERPDocumentLineDeliveryStatus
    {
        /// <summary>Delivery state not recorded.</summary>
        Unknown = 0,

        /// <summary>Awaiting fulfilment.</summary>
        Open = 10,
        Planned = 20,
        /// <summary>Stock reserved for this line.</summary>
        Reserved = 40,
        /// <summary>Stock allocated to this line.</summary>
        Allocated = 60,
        /// <summary>Goods loaded for shipment.</summary>
        Loaded = 80,
        Shipped = 100,
        Delivered = 120,

        Cancelled = 200,

        /// <summary>Handled internally; not part of an external delivery.</summary>
        Internal = 800
    }
}
