using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPDocumentLine"/>.
    /// </summary>
    public static class ERPDocumentLineExtensions
    {
        /// <summary>Trims whitespace from the line, its identification entries and its custom fields, in place.</summary>
        public static void Trim(this ERPDocumentLine erpDocumentLine)
        {
            erpDocumentLine.TrimPublicStringProperties();

            foreach (var erpDocumentLineIdentification in erpDocumentLine.Identification)
                erpDocumentLineIdentification.TrimPublicStringProperties();

            erpDocumentLine.CustomFields.Trim();
        }

        /// <summary>Trims whitespace from every document line in the list, in place.</summary>
        public static void Trim(this List<ERPDocumentLine> erpDocumentLines)
        {
            foreach (var erpDocumentLine in erpDocumentLines)
                Trim(erpDocumentLine);
        }
    }
}
