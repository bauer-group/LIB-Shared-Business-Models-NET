using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPEditor"/>.
    /// </summary>
    public static class ERPEditorExtensions
    {
        /// <summary>Trims whitespace from every public string property of the editor, in place.</summary>
        public static void Trim(this ERPEditor erpEditor)
        {
            erpEditor.TrimPublicStringProperties();
        }
    }
}
