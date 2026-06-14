using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Labeling / coding scheme used to identify a product.
    /// </summary>
    public enum ERPProductLabelingType
    {
        /// <summary>A scheme that does not fit the predefined values.</summary>
        Other = -1,

        /// <summary>Scheme not determined.</summary>
        Unkown = 0,

        Barcode = 1,
        RFID = 2,

        GTIN_Barcode = 100,
        GS1_128_Barcode = 101,
        SSCC_Barcode = 102,

        /// <summary>Electronic Product Code carried on an RFID tag.</summary>
        EPC_RFID = 200, //Electronic Product Code
    }
}
