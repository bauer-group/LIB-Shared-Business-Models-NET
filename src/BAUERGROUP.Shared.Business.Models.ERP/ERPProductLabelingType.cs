using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPProductLabelingType
    {
        Other = -1,
        
        Unkown = 0,

        Barcode = 1,
        RFID = 2,

        GTIN_Barcode = 100,
        GS1_128_Barcode = 101,
        SSCC_Barcode = 102,

        EPC_RFID = 200, //Electronic Product Code
    }
}
