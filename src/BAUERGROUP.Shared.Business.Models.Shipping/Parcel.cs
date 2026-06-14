using System;
using BAUERGROUP.Shared.Business.Models.Shipping.Interfaces;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// One physical parcel shipment. Implements <see cref="IParcel"/> and carries sender/receiver
    /// addresses, weight/value, carrier and product selection, service options, customs data,
    /// packaging and a derived <see cref="Status"/>.
    /// </summary>
    public class Parcel: IParcel
    {
        /// <summary>Initialises a new parcel with neutral defaults (empty addresses, EUR currency, DHL carrier, released control).</summary>
        public Parcel()
        {
            Sender = new ParcelAddress();
            Receiver = new ParcelAddress();

            ReturnReceiver = null;

            Reference = @"";
            SSCC = @"";
            ShipmentDate = DateTime.UtcNow;
            ShipmentNumber = @"";
            Weight = 0.0m;
            Value = 0.0m;

            Currency = ShippingCurrency.EUR;

            Carrier = FreightCarriers.DHL_BusinessClientShipping;
            Product = FreightCarrierProducts.Default;
            ServiceOption = new List<FreightCarrierServices>(0);

            Control = ParcelControl.Released;

            PrintCount = 0;

            Timestamp = DateTime.UtcNow;
            Documents = new List<ShippingDocument>(0);

            Packaging = null;

            Costs = 0m;

            PartnersReference = @"";

            Images = null;

            Contents = null;

            ServiceParameters = null;

            Customs = null;

            CarrierSpecificData = null;

            CarrierDocuments = null;            
        }

        /// <summary>Sender (origin) address.</summary>
        public ParcelAddress Sender { get; set; }
        /// <summary>Receiver (destination) address.</summary>
        public ParcelAddress Receiver { get; set; }

        /// <summary>Address goods are returned to (<c>null</c> if no return address).</summary>
        public ParcelAddress ReturnReceiver { get; set; }

        /// <summary>Free-text reference for the parcel.</summary>
        public String Reference { get; set; }

        /// <summary>Serial Shipping Container Code identifying the parcel.</summary>
        public String SSCC { get; set; }

        /// <summary>Date the parcel is to be shipped.</summary>
        public DateTime ShipmentDate { get; set; }
        /// <summary>Carrier shipment (tracking) number; empty until assigned.</summary>
        public String ShipmentNumber { get; set; }

        /// <summary>Gross weight of the parcel.</summary>
        public Decimal Weight { get; set; }

        /// <summary>Declared value of the contents, in <see cref="Currency"/>.</summary>
        public Decimal Value { get; set; }

        /// <summary>Currency of the parcel's monetary values.</summary>
        public ShippingCurrency Currency { get; set; }

        /// <summary>Freight carrier handling the parcel.</summary>
        public FreightCarriers Carrier { get; set; }
        /// <summary>Carrier product/service tier selected for the parcel.</summary>
        public FreightCarrierProducts Product { get; set; }
        /// <summary>Additional carrier service options requested for the parcel.</summary>
        public List<FreightCarrierServices> ServiceOption { get; set; }

        /// <summary>Derived processing status: <c>Complete</c> once a shipment number exists, otherwise <c>Printed</c> when printed, else <c>Open</c>.</summary>
        public ParcelStatus Status
        {
            get
            {
                if (ShipmentNumber != String.Empty)
                    return ParcelStatus.Complete;

                if (PrintCount > 0)
                    return ParcelStatus.Printed;

                return ParcelStatus.Open;
            } 
        }

        /// <summary>Processing-control state governing whether the parcel may ship.</summary>
        public ParcelControl Control { get; set; }

        /// <summary>Number of times the parcel label has been printed.</summary>
        public UInt16 PrintCount { get; set; }

        /// <summary>UTC timestamp of the last change to the parcel.</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Documents attached to the shipment.</summary>
        public List<ShippingDocument> Documents { get; set; }

        /// <summary>Packaging used for the parcel (<c>null</c> if not specified).</summary>
        public ParcelPackaging Packaging { get; set; }

        /// <summary>Shipping costs for the parcel, in <see cref="Currency"/>.</summary>
        public Decimal Costs { get; set; }

        /// <summary>Reference assigned by a partner/external system.</summary>
        public String PartnersReference { get; set; }

        /// <summary>Images attached to the shipment (<c>null</c> if none).</summary>
        public List<ShippingImage> Images { get; set; }

        /// <summary>Itemised contents of the parcel (<c>null</c> if none).</summary>
        public List<ShippingContents> Contents { get; set; }

        /// <summary>Value-added service parameters (<c>null</c> if none).</summary>
        public ShippingServiceParameters ServiceParameters { get; set; }

        /// <summary>Customs declaration for cross-border shipments (<c>null</c> if domestic).</summary>
        public ParcelCustoms Customs { get; set; }

        /// <summary>Carrier-specific payload that does not map to the common surface (<c>null</c> if none).</summary>
        public ShippingCarrierSpecificData CarrierSpecificData { get; set; }

        /// <summary>Carrier-generated documents for the parcel, e.g. labels (<c>null</c> if none).</summary>
        public List<CarrierDocument> CarrierDocuments { get; set; }
    }
}
