using BAUERGROUP.Shared.Business.Models.Shipping.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ParcelShippingStatus : IParcelShippingStatus
    {
        public ParcelShippingStatus()
        {
            SSCC = @"";
            Carrier = FreightCarriers.DHL_Easylog;
            ShipmentNumber = @"";
            Status = ParcelShippingStatusCode.Announced;
            Timestamp = DateTime.UtcNow;
        }

        public string SSCC { get; set; }
        public FreightCarriers Carrier { get; set; }
        public string ShipmentNumber { get; set; }

        public ParcelShippingStatusCode Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
