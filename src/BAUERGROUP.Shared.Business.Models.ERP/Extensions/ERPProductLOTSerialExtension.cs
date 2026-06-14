using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPProductLOTSerialExtension
    {
        public static void Trim(this ERPProductLOTSerial erpProductLOTSerial)
        {
            erpProductLOTSerial.TrimPublicStringProperties();
        }

        public static void Trim(this List<ERPProductLOTSerial> erpProductLOTSerials)
        {
            foreach (var erpProductLOTSerial in erpProductLOTSerials)
                Trim(erpProductLOTSerial);
        }
    }
}
