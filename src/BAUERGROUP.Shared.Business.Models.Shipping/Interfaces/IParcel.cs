using System;
using System.Collections.Generic;
using System.Drawing;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Interfaces
{
    public interface IParcel
    {        
        ParcelAddress Sender { get; set; }
        ParcelAddress Receiver { get; set; }
        
        ParcelAddress ReturnReceiver { get; set; }

        String Reference { get; set; }

        String PartnersReference { get; set; }

        String SSCC { get; set; }

        DateTime ShipmentDate { get; set; }
        String ShipmentNumber { get; set; }

        Decimal Weight { get; set; }

        Decimal Value { get; set; }

        ShippingCurrency Currency { get; set; }

        FreightCarriers Carrier { get; set; }
        FreightCarrierProducts Product { get; set; }
        List<FreightCarrierServices> ServiceOption { get; set; }

        ParcelStatus Status { get; }
        ParcelControl Control { get; set; }
        
        UInt16 PrintCount { get; set; }

        DateTime Timestamp { get; set; }

        List<ShippingDocument> Documents { get; set; }

        ParcelPackaging Packaging { get; set; }

        List<ShippingImage> Images { get; set; }

        List<ShippingContents> Contents { get; set; }

        ShippingServiceParameters ServiceParameters { get; set; }

        ParcelCustoms Customs { get; set; }

        ShippingCarrierSpecificData CarrierSpecificData { get; set; }
    }
}
