using System;
using BAUERGROUP.Shared.Core.Images;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A timestamped image attached to a shipment (e.g. proof of delivery or parcel photo).
    /// </summary>
    public class ShippingImage
    {
        /// <summary>Initialises a new instance with the current UTC timestamp and no picture.</summary>
        public ShippingImage()
        {
            Timestamp = DateTime.UtcNow;
            Picture = null;
        }

        /// <summary>The image payload (<c>null</c> if not set).</summary>
        public IndependentImage Picture { get; set; }
        /// <summary>UTC time the image was captured or attached.</summary>
        public DateTime Timestamp { get; set; }
    }
}
