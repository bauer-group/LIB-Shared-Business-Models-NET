using System;
using System.ComponentModel;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Value-added carrier delivery services that can be requested for a shipment. The
    /// <see cref="DescriptionAttribute"/> on each member carries the German display label.
    /// </summary>
    public enum FreightCarrierServices
    {
        /// <summary>Cash on delivery (Nachnahme).</summary>
        [Description("Nachnahme")]
        COD = 10,

        /// <summary>Bulky-goods handling (Sperrgut).</summary>
        [Description("Sperrgut")]
        Bulky = 20,

        /// <summary>Guaranteed delivery before 08:00.</summary>
        [Description("Zustellung vor 8 Uhr")]
        E8 = 30,

        /// <summary>Guaranteed delivery before 09:00.</summary>
        [Description("Zustellung vor 9 Uhr")]
        E9 = 40,

        /// <summary>Guaranteed delivery before 10:00.</summary>
        [Description("Zustellung vor 10 Uhr")]
        E10 = 50,

        /// <summary>Guaranteed delivery before 12:00.</summary>
        [Description("Zustellung vor 12 Uhr")]
        E12 = 60,

        /// <summary>Guaranteed delivery before 18:00.</summary>
        [Description("Zustellung vor 18 Uhr")]
        E18 = 70,

        /// <summary>Saturday delivery.</summary>
        [Description("Samstagszustellung")]
        Saturday = 80,

        [Description("Sonntagsszustellung")]
        Sunday = 90,

        [Description("Höherversicherung")]
        Insurance = 100,

        [Description("Wertsendung")]
        Valuables = 110,

        [Description("Avisierung")]
        Notification = 200,

        [Description("Fahrer Avisierung")]
        DriverNotification = 210,

        [Description("Fester Liefertermin")]
        FirmDeliveryDate = 300,

        [Description("Bevorzugter Liefertermin")]
        PreferredDeliveryDate = 310,

        [Description("Identitätsfeststellung")]
        IdentityVerification = 400,

        [Description("Altersverifikation")]
        AgeVerification = 410,

        [Description("Eigenhändig")]
        PersonalDelivery = 420,

        [Description("Keine Nachbarschaftszustellung")]
        NoNeighborDelivery = 430,

        [Description("Ersatzzustellung am Ablageort")]
        PreferredLocationDelivery = 440,

        [Description("Ersatzzustellung beim Wunschnachbarn")]
        PreferredNeighbourDelivery = 450,

        [Description("Filialrouting")]
        StoreDelivery = 500,

        [Description("Umweltfreundlich")]
        EnvironmentallyFriendly = 600,

        [Description("Taggleiche Zustellung")]
        SameDay = 700,

        [Description("Priorisierte Zustellung")]
        Priority = 710,

        [Description("Abendzustellung")]
        EveningDelivery = 720,

        [Description("Zerbrechlich")]
        Fragile = 800
    }
}
