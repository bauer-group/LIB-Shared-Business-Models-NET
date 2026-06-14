using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Interfaces
{
    /// <summary>
    /// Contract for a single carrier tracking event of a parcel.
    /// </summary>
    public interface IParcelShippingStatus
    {
        /// <summary>SSCC identifying the parcel this status applies to.</summary>
        string SSCC { get; set; }
        /// <summary>Carrier that reported the tracking event.</summary>
        FreightCarriers Carrier { get; set; }
        /// <summary>Carrier shipment (tracking) number.</summary>
        string ShipmentNumber { get; set; }

        /// <summary>Tracking status code for this event.</summary>
        ParcelShippingStatusCode Status { get; set; }
        /// <summary>UTC time the tracking event occurred.</summary>
        DateTime Timestamp { get; set; }
    }
}
