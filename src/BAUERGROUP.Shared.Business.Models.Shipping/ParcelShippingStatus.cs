using System;
using BAUERGROUP.Shared.Business.Models.Shipping.Interfaces;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A single carrier tracking event for a parcel. Implements <see cref="IParcelShippingStatus"/>.
    /// </summary>
    public class ParcelShippingStatus : IParcelShippingStatus
    {
        /// <summary>Initialises a new instance with neutral defaults and the current UTC timestamp.</summary>
        public ParcelShippingStatus()
        {
            SSCC = @"";
            Carrier = FreightCarriers.DHL_Easylog;
            ShipmentNumber = @"";
            Status = ParcelShippingStatusCode.Announced;
            Timestamp = DateTime.UtcNow;
        }

        /// <summary>SSCC identifying the parcel this status applies to.</summary>
        public string SSCC { get; set; }
        /// <summary>Carrier that reported the tracking event.</summary>
        public FreightCarriers Carrier { get; set; }
        /// <summary>Carrier shipment (tracking) number.</summary>
        public string ShipmentNumber { get; set; }

        /// <summary>Tracking status code for this event.</summary>
        public ParcelShippingStatusCode Status { get; set; }
        /// <summary>UTC time the tracking event occurred.</summary>
        public DateTime Timestamp { get; set; }
    }
}
