using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
