using BAUERGROUP.Shared.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPDocumentLineExtensions
    {
        public static void Trim(this ERPDocumentLine erpDocumentLine)
        {
            erpDocumentLine.TrimPublicStringProperties();

            foreach (var erpDocumentLineIdentification in erpDocumentLine.Identification)
                erpDocumentLineIdentification.TrimPublicStringProperties();

            erpDocumentLine.CustomFields.Trim();
        }

        public static void Trim(this List<ERPDocumentLine> erpDocumentLines)
        {
            foreach (var erpDocumentLine in erpDocumentLines)
                Trim(erpDocumentLine);
        }
    }
}
