using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A document attached to an <see cref="ERPBusinessAssociate"/>. Extends <see cref="ERPAttachment"/>
    /// (file mode) and adds an attachment <see cref="Type"/> classification.
    /// </summary>
    public class ERPBusinessAssociateAttachment : ERPAttachment
    {
        /// <summary>Initialises a new file attachment with <see cref="ERPBusinessAssociateAttachmentType.Other"/> type.</summary>
        public ERPBusinessAssociateAttachment() :
            base(ERPAttachmentMode.File)
        {
            Type = ERPBusinessAssociateAttachmentType.Other;
        }

        /// <summary>Initialises a new file attachment with the given name, filename and type.</summary>
        /// <param name="sName">Display name of the attachment.</param>
        /// <param name="sFilename">File name / path of the attachment.</param>
        /// <param name="eType">Attachment classification (defaults to <see cref="ERPBusinessAssociateAttachmentType.Other"/>).</param>
        public ERPBusinessAssociateAttachment(string sName, string sFilename, ERPBusinessAssociateAttachmentType eType = ERPBusinessAssociateAttachmentType.Other) :
            base(sName, sFilename, ERPAttachmentMode.File)
        {
            Type = eType;
        }

        /// <summary>Classification of the attachment.</summary>
        public ERPBusinessAssociateAttachmentType Type { get; set; }
    }
}
