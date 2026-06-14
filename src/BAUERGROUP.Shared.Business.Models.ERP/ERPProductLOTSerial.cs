using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductLOTSerial : ERPObjectBase
    {
        public ERPProductLOTSerial() :
            this(@"", null, ERPProductLOTSerialType.LOT)
        {
            
        }

        public ERPProductLOTSerial(string sCode, ERPProductLOTSerialType eType = ERPProductLOTSerialType.LOT) :
            this(sCode, null, eType)
        {
            
        }

        public ERPProductLOTSerial(string sCode, DateTime? dtMinimumDurability, ERPProductLOTSerialType eType = ERPProductLOTSerialType.LOT)
        {
            Code = sCode;
            MinimumDurabilityDate = dtMinimumDurability;
            Type = eType;
        }

        public string Code { get; set; }
        public DateTime? MinimumDurabilityDate { get; set; }

        public ERPProductLOTSerialType Type { get; set; }
    }
}
