using System;
using System.ComponentModel;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Carrier catalogue of shipping products (parcels, letters, commodity post, cargo). The
    /// <see cref="DescriptionAttribute"/> on each member carries the German product label.
    /// </summary>
    public enum FreightCarrierProducts
    {
        //Parcels
        /// <summary>Default product — standard parcel shipping.</summary>
        [Description("Standardversand (Paket)")]
        Default = 0,

        [Description("Expressversand (Paket)")]
        Express = 1,

        //Letters
        [Description("Dokumentensendung (Brief)")]
        Letter = 100,
        
        [Description("Warensendung (Brief)")]
        LetterGoods = 101,
        
        [Description("Dokumentensendung (Kompaktbrief)")]
        LetterCompact = 102,
        
        [Description("Dokumentensendung (Großbrief)")]
        LetterLarge = 103,

        [Description("Dokumentensendung (Maxibrief)")]
        LetterXLarge = 104,
        
        [Description("Warensendung (Maxibrief)")]
        LetterGoodsLarge = 105,
        
        [Description("Dokumentensendung (Brief) International")]
        LetterInternational = 120,

        [Description("Dokumentensendung (Kompaktbrief) International")]
        LetterCompactInternational = 121,

        [Description("Dokumentensendung (Großbrief) International")]
        LetterLargeInternational = 122,

        [Description("Dokumentensendung (Maxibrief) International")]
        LetterXLargeInternational = 123,

        [Description("Dokumentensendung (Brief) Einschreiben")]
        LetterRegistered = 124,

        [Description("Dokumentensendung (Kompaktbrief) Einschreiben")]
        LetterCompactRegistered = 125,

        [Description("Dokumentensendung (Großbrief) Einschreiben")]
        LetterLargeRegistered = 126,

        [Description("Dokumentensendung (Maxibrief) Einschreiben")]
        LetterXLargeRegistered = 127,

        [Description("Dokumentensendung (Brief) International Einschreiben")]
        LetterInternationalRegistered = 128,

        [Description("Dokumentensendung (Kompaktbrief) International Einschreiben")]
        LetterCompactInternationalRegistered = 129,

        [Description("Dokumentensendung (Großbrief) International Einschreiben")]
        LetterLargeInternationalRegistered = 130,

        [Description("Dokumentensendung (Maxibrief) International Einschreiben")]
        LetterXLargeInternationalRegistered = 131,

        //Commodity Post - Domestic
        [Description("Warenpost mit Sendungsverfolgung (M)")]
        CommodityPostRegisteredM = 140,

        [Description("Warenpost mit Sendungsverfolgung (L)")]
        CommodityPostRegisteredL = 141,

        [Description("Warenpost mit Sendungsverfolgung (Individuell)")]
        CommodityPostRegisteredCustom = 150,

        //Commodity Post - International
        [Description("Warenpost mit Sendungsverfolgung International (XS)")]
        CommodityPostRegisteredInternationalXS = 142,

        [Description("Warenpost mit Sendungsverfolgung International (S)")]
        CommodityPostRegisteredInternationalS = 143,

        [Description("Warenpost mit Sendungsverfolgung International (M)")]
        CommodityPostRegisteredInternationalM = 144,

        [Description("Warenpost mit Sendungsverfolgung International (L)")]
        CommodityPostRegisteredInternationalL = 145,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift International (XS)")]
        CommodityPostRegisteredSignatureInternationalXS = 146,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift International (S)")]
        CommodityPostRegisteredSignatureInternationalS = 147,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift International (M)")]
        CommodityPostRegisteredSignatureInternationalM = 148,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift International (L)")]
        CommodityPostRegisteredSignatureInternationalL = 149,

        [Description("Warenpost International (XS)")]
        CommodityPostInternationalXS = 151,

        [Description("Warenpost International (S)")]
        CommodityPostInternationalS = 152,

        [Description("Warenpost International (M)")]
        CommodityPostInternationalM = 153,

        [Description("Warenpost International (L)")]
        CommodityPostInternationalL = 154,

        //Commodity Post - EU
        [Description("Warenpost mit Sendungsverfolgung EU (XS)")]
        CommodityPostRegisteredEUXS = 155,

        [Description("Warenpost mit Sendungsverfolgung EU (S)")]
        CommodityPostRegisteredEUS = 156,

        [Description("Warenpost mit Sendungsverfolgung EU (M)")]
        CommodityPostRegisteredEUM = 157,

        [Description("Warenpost mit Sendungsverfolgung EU (L)")]
        CommodityPostRegisteredEUL = 158,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift EU (XS)")]
        CommodityPostRegisteredSignatureEUXS = 159,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift EU (S)")]
        CommodityPostRegisteredSignatureEUS = 160,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift EU (M)")]
        CommodityPostRegisteredSignatureEUM = 161,

        [Description("Warenpost mit Sendungsverfolgung + Unterschrift EU (L)")]
        CommodityPostRegisteredSignatureEUL = 162,

        [Description("Warenpost EU (XS)")]
        CommodityPostEUXS = 163,

        [Description("Warenpost EU (S)")]
        CommodityPostEUS = 164,

        [Description("Warenpost EU (M)")]
        CommodityPostEUM = 165,

        [Description("Warenpost EU (L)")]
        CommodityPostEUL = 166,

        //Cargo
        [Description("Pallettenversand (Standard)")]
        Pallet = 200,

        [Description("Pallettenversand (Express)")]
        PalletExpress = 201,

        //Other
        /// <summary>A shipping product that does not fit the predefined catalogue.</summary>
        [Description("Andere Versandart")]
        Other = 1000
    }
}
