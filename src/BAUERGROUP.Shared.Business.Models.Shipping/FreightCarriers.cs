using System;
using System.ComponentModel;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Freight carriers and shipping channels, identified by their specific carrier system/product.
    /// The <see cref="DescriptionAttribute"/> on each member carries the German display label.
    /// </summary>
    public enum FreightCarriers
    {
        /// <summary>DHL via the Easylog shipping software (Germany).</summary>
        [Description("DHL, Easylog (DE)")]
        DHL_Easylog = 1,

        /// <summary>Deutsche Post (Germany).</summary>
        [Description("Deutsche Post (DE)")]
        Deutsche_Post = 2,

        /// <summary>General cargo / palletised freight (Stückgut).</summary>
        [Description("Stückgut")]
        Cargo = 3,

        /// <summary>DHL via the Geschäftskundenversand / "Versenden" business-client portal (Germany).</summary>
        [Description("DHL, Versenden (DE)")]
        DHL_BusinessClientShipping = 4,

        /// <summary>UPS via the WorldShip shipping software.</summary>
        [Description("UPS Worldship")]
        UPS_Worldship = 5,

        /// <summary>DPD via the DELISprint shipping software (Germany).</summary>
        [Description("DPD DELISprint (DE)")]
        DPD_DelisPrint = 6,

        /// <summary>Österreichische Post / Post Austria (Austria).</summary>
        [Description("Post Austria (AT)")]
        Post_Austria = 7,

        /// <summary>Deutsche Post via DV-Freimachung (data-processed franking, Germany).</summary>
        [Description("Deutsche Post DV-Freimachung (DE)")]
        Deutsche_Post_DV = 8,

        /// <summary>FedEx via the Stratus shipping software.</summary>
        [Description("FedEx Stratus")]
        FedEx_Stratus = 9,

        /// <summary>Amazon Shipping (Germany).</summary>
        [Description("Amazon Versand (DE)")]
        AmazonShipping = 100,

        /// <summary>Two-man handling / delivery service for bulky goods.</summary>
        [Description("2 Mann Handhabung")]
        TwoManHandling = 500,

        /// <summary>Customer self-collection — no carrier involved.</summary>
        [Description("Selbstabholung")]
        WillCollect = 1000,

        /// <summary>Internal goods movement between own sites — not an external carrier.</summary>
        [Description("Interner Warenverkehr")]
        InternalMovement = 2000
    }
}
