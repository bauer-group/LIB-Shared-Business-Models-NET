using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A file attached to a product. Extends <see cref="ERPAttachment"/> and adds the
    /// product-specific attachment category.
    /// </summary>
    public class ERPProductAttachment : ERPAttachment
    {
        /// <summary>Initialises a new embedded attachment with an <see cref="ERPProductAttachmentType.Other"/> type.</summary>
        public ERPProductAttachment() :
            base(ERPAttachmentMode.Embedded)
        {
            Type = ERPProductAttachmentType.Other;
        }

        /// <summary>Initialises a new file-mode attachment with the given name, filename and type.</summary>
        /// <param name="sName">Display name of the attachment.</param>
        /// <param name="sFilename">Source filename of the attachment.</param>
        /// <param name="eType">Attachment category (defaults to <see cref="ERPProductAttachmentType.Other"/>).</param>
        public ERPProductAttachment(string sName, string sFilename, ERPProductAttachmentType eType = ERPProductAttachmentType.Other) :
            base(sName, sFilename, ERPAttachmentMode.File)
        {
            Type = eType;
        }

        /// <summary>Category of the attached file.</summary>
        public ERPProductAttachmentType Type { get; set; }
    }
}
