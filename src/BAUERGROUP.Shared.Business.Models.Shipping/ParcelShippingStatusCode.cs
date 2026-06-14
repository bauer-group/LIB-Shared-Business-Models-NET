using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public enum ParcelShippingStatusCode
    {
        [Description("angekündigt")]
        Announced = 10,

        [Description("verladen")]
        Loaded = 20,

        [Description("im Startpaketzentrum")]
        AtSourceParcelCenter = 30,

        [Description("verzögerte Bearbeitung")]
        Delayed = 40,

        [Description("im Zielpaketzentrum")]
        AtDestinationParcelCenter = 50,

        [Description("auf Zustellfahrzeug")]
        OnDeliveryVehicle = 60,

        [Description("zugestellt")]
        Delivered = 70,

        [Description("abholbereit")]
        ReadyForPickUp = 80,

        [Description("nicht zustellbar")]
        Undeliverable = 90,

        [Description("retourniert")]
        Returned = 100
    }
}
