using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPProductLOTSerial"/>.
    /// </summary>
    public static class ERPProductLOTSerialExtension
    {
        /// <summary>Trims whitespace from every public string property of the LOT/serial, in place.</summary>
        public static void Trim(this ERPProductLOTSerial erpProductLOTSerial)
        {
            erpProductLOTSerial.TrimPublicStringProperties();
        }

        /// <summary>Trims whitespace from every LOT/serial in the list, in place.</summary>
        public static void Trim(this List<ERPProductLOTSerial> erpProductLOTSerials)
        {
            foreach (var erpProductLOTSerial in erpProductLOTSerials)
                Trim(erpProductLOTSerial);
        }
    }
}
