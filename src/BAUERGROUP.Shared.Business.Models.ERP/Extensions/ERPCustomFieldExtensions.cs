using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPCustomField"/>.
    /// </summary>
    public static class ERPCustomFieldExtensions
    {
        /// <summary>Trims whitespace from every public string property of the custom field, in place.</summary>
        public static void Trim(this ERPCustomField erpCustomField)
        {
            erpCustomField.TrimPublicStringProperties();
        }

        /// <summary>Trims whitespace from every custom field in the list, in place.</summary>
        public static void Trim(this List<ERPCustomField> erpCustomFields)
        {
            foreach (var erpCustomField in erpCustomFields)
                Trim(erpCustomField);
        }
    }
}
