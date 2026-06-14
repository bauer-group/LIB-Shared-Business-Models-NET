using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Interfaces
{
    public interface IParcelShippingStatus
    {
        string SSCC { get; set; }
        FreightCarriers Carrier { get; set; }
        string ShipmentNumber { get; set; }

        ParcelShippingStatusCode Status { get; set; }
        DateTime Timestamp { get; set; }
    }
}
