using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// How a <see cref="ShippingDocument"/> payload is carried.
    /// </summary>
    public enum ShippingDocumentMode
    {
        /// <summary>Referenced by file path / name.</summary>
        File = 0,
        /// <summary>Carried inline as byte content.</summary>
        Embedded = 1,
        /// <summary>Referenced by URI.</summary>
        URI = 2
    }
}