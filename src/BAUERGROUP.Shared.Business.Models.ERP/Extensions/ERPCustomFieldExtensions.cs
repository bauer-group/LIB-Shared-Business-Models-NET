using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPCustomFieldExtensions
    {
        public static void Trim(this ERPCustomField erpCustomField)
        {
            erpCustomField.TrimPublicStringProperties();
        }

        public static void Trim(this List<ERPCustomField> erpCustomFields)
        {
            foreach (var erpCustomField in erpCustomFields)
                Trim(erpCustomField);
        }
    }
}
