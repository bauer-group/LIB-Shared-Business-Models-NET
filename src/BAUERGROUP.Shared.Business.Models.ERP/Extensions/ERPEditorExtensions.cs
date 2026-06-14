using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPEditorExtensions
    {
        public static void Trim(this ERPEditor erpEditor)
        {
            erpEditor.TrimPublicStringProperties();
        }
    }
}
