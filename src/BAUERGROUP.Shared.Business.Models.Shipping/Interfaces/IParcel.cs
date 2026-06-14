using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Interfaces
{
    /// <summary>
    /// Contract for a single physical parcel shipment — addresses, weight/value, carrier and
    /// product selection, service options, customs data, packaging and derived status.
    /// </summary>
    public interface IParcel
    {
        /// <summary>Sender (origin) address.</summary>
        ParcelAddress Sender { get; set; }
        /// <summary>Receiver (destination) address.</summary>
        ParcelAddress Receiver { get; set; }

        /// <summary>Address goods are returned to (<c>null</c> if no return address).</summary>
        ParcelAddress ReturnReceiver { get; set; }

        /// <summary>Free-text reference for the parcel.</summary>
        String Reference { get; set; }

        /// <summary>Reference assigned by a partner/external system.</summary>
        String PartnersReference { get; set; }

        /// <summary>Serial Shipping Container Code identifying the parcel.</summary>
        String SSCC { get; set; }

        /// <summary>Date the parcel is to be shipped.</summary>
        DateTime ShipmentDate { get; set; }
        /// <summary>Carrier shipment (tracking) number; empty until assigned.</summary>
        String ShipmentNumber { get; set; }

        /// <summary>Gross weight of the parcel.</summary>
        Decimal Weight { get; set; }

        /// <summary>Declared value of the contents, in <see cref="Currency"/>.</summary>
        Decimal Value { get; set; }

        /// <summary>Currency of the parcel's monetary values.</summary>
        ShippingCurrency Currency { get; set; }

        /// <summary>Freight carrier handling the parcel.</summary>
        FreightCarriers Carrier { get; set; }
        /// <summary>Carrier product/service tier selected for the parcel.</summary>
        FreightCarrierProducts Product { get; set; }
        /// <summary>Additional carrier service options requested for the parcel.</summary>
        List<FreightCarrierServices> ServiceOption { get; set; }

        /// <summary>Derived processing status of the parcel.</summary>
        ParcelStatus Status { get; }
        /// <summary>Processing-control state governing whether the parcel may ship.</summary>
        ParcelControl Control { get; set; }

        /// <summary>Number of times the parcel label has been printed.</summary>
        UInt16 PrintCount { get; set; }

        /// <summary>UTC timestamp of the last change to the parcel.</summary>
        DateTime Timestamp { get; set; }

        /// <summary>Documents attached to the shipment.</summary>
        List<ShippingDocument> Documents { get; set; }

        /// <summary>Packaging used for the parcel (<c>null</c> if not specified).</summary>
        ParcelPackaging Packaging { get; set; }

        /// <summary>Images attached to the shipment (<c>null</c> if none).</summary>
        List<ShippingImage> Images { get; set; }

        /// <summary>Itemised contents of the parcel (<c>null</c> if none).</summary>
        List<ShippingContents> Contents { get; set; }

        /// <summary>Value-added service parameters (<c>null</c> if none).</summary>
        ShippingServiceParameters ServiceParameters { get; set; }

        /// <summary>Customs declaration for cross-border shipments (<c>null</c> if domestic).</summary>
        ParcelCustoms Customs { get; set; }

        /// <summary>Carrier-specific payload that does not map to the common surface (<c>null</c> if none).</summary>
        ShippingCarrierSpecificData CarrierSpecificData { get; set; }
    }
}
