using System;
using System.ComponentModel;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Carrier tracking-event code describing where a parcel is in the delivery chain.
    /// </summary>
    public enum ParcelShippingStatusCode
    {
        /// <summary>Shipment data transmitted to the carrier; parcel not yet handed over.</summary>
        [Description("angekündigt")]
        Announced = 10,

        /// <summary>Picked up and loaded by the carrier.</summary>
        [Description("verladen")]
        Loaded = 20,

        /// <summary>Arrived at the origin parcel center.</summary>
        [Description("im Startpaketzentrum")]
        AtSourceParcelCenter = 30,

        /// <summary>Processing delayed.</summary>
        [Description("verzögerte Bearbeitung")]
        Delayed = 40,

        /// <summary>Arrived at the destination parcel center.</summary>
        [Description("im Zielpaketzentrum")]
        AtDestinationParcelCenter = 50,

        /// <summary>Out for delivery on a delivery vehicle.</summary>
        [Description("auf Zustellfahrzeug")]
        OnDeliveryVehicle = 60,

        /// <summary>Successfully delivered to the recipient.</summary>
        [Description("zugestellt")]
        Delivered = 70,

        /// <summary>Held for pickup at a collection point.</summary>
        [Description("abholbereit")]
        ReadyForPickUp = 80,

        /// <summary>Could not be delivered.</summary>
        [Description("nicht zustellbar")]
        Undeliverable = 90,

        /// <summary>Returned to the sender.</summary>
        [Description("retourniert")]
        Returned = 100
    }
}
