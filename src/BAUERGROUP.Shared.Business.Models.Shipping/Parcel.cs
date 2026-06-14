using System;
using BAUERGROUP.Shared.Business.Models.Shipping.Interfaces;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class Parcel: IParcel
    {
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

        public ParcelAddress Sender { get; set; }
        public ParcelAddress Receiver { get; set; }

        public ParcelAddress ReturnReceiver { get; set; }

        public String Reference { get; set; }

        public String SSCC { get; set; }

        public DateTime ShipmentDate { get; set; }
        public String ShipmentNumber { get; set; }

        public Decimal Weight { get; set; }

        public Decimal Value { get; set; }

        public ShippingCurrency Currency { get; set; }

        public FreightCarriers Carrier { get; set; }
        public FreightCarrierProducts Product { get; set; }
        public List<FreightCarrierServices> ServiceOption { get; set; }

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

        public ParcelControl Control { get; set; }

        public UInt16 PrintCount { get; set; }

        public DateTime Timestamp { get; set; }

        public List<ShippingDocument> Documents { get; set; }

        public ParcelPackaging Packaging { get; set; }

        public Decimal Costs { get; set; }

        public String PartnersReference { get; set; }

        public List<ShippingImage> Images { get; set; }

        public List<ShippingContents> Contents { get; set; }

        public ShippingServiceParameters ServiceParameters { get; set; }

        public ParcelCustoms Customs { get; set; }

        public ShippingCarrierSpecificData CarrierSpecificData { get; set; }

        public List<CarrierDocument> CarrierDocuments { get; set; }
    }
}
