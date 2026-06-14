using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{    
    public enum ERPProductLOTSerialType
    {
        None = 0,

        LOT = 1,
        Serial = 2,

        MAC = 100,
        IMEI = 101,
        SIM = 102,

        UUID = 200,

        MinimumDurabilityDate = 300,

        Custom = 1000
    }
}
