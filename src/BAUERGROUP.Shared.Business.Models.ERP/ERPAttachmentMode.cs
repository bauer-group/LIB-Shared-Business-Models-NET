using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// How an <see cref="ERPAttachment"/> payload is stored or referenced.
    /// </summary>
    public enum ERPAttachmentMode
    {
        /// <summary>Attachment is referenced by file path / name.</summary>
        File = 0,
        /// <summary>Attachment bytes are embedded inline.</summary>
        Embedded = 1,
        /// <summary>Attachment is referenced by an external URI.</summary>
        URI = 2
    }
}
