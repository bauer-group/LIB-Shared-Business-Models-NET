using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public enum FreightCarriers
    {
        [Description("DHL, Easylog (DE)")]
        DHL_Easylog = 1,

        [Description("Deutsche Post (DE)")]
        Deutsche_Post = 2,

        [Description("Stückgut")]
        Cargo = 3,

        [Description("DHL, Versenden (DE)")]
        DHL_BusinessClientShipping = 4,

        [Description("UPS Worldship")]
        UPS_Worldship = 5,

        [Description("DPD DELISprint (DE)")]
        DPD_DelisPrint = 6,

        [Description("Post Austria (AT)")]
        Post_Austria = 7,

        [Description("Deutsche Post DV-Freimachung (DE)")]
        Deutsche_Post_DV = 8,

        [Description("FedEx Stratus")]
        FedEx_Stratus = 9,

        [Description("Amazon Versand (DE)")]
        AmazonShipping = 100,

        [Description("2 Mann Handhabung")]
        TwoManHandling = 500,

        [Description("Selbstabholung")]
        WillCollect = 1000,

        [Description("Interner Warenverkehr")]
        InternalMovement = 2000
    }
}
