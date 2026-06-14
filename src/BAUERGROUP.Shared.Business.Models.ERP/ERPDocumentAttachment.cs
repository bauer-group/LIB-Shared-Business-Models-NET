using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A file attached to an <see cref="ERPDocument"/>. Extends <see cref="ERPAttachment"/>
    /// and adds the document-specific attachment role (<see cref="ERPDocumentAttachmentType"/>).
    /// </summary>
    public class ERPDocumentAttachment : ERPAttachment
    {
        /// <summary>Initialises a new file-mode attachment with role <see cref="ERPDocumentAttachmentType.Other"/>.</summary>
        public ERPDocumentAttachment() :
            base(ERPAttachmentMode.File)
        {            
            Type = ERPDocumentAttachmentType.Other;            
        }

        /// <summary>Initialises a new file-reference attachment from a name and file path.</summary>
        /// <param name="sName">Display name of the attachment.</param>
        /// <param name="sFilename">Path of the referenced file.</param>
        /// <param name="eType">Attachment role; defaults to <see cref="ERPDocumentAttachmentType.Other"/>.</param>
        public ERPDocumentAttachment(String sName, String sFilename, ERPDocumentAttachmentType eType = ERPDocumentAttachmentType.Other):
            base(sName, sFilename, ERPAttachmentMode.File)
        {
            Type = eType;            
        }

        /// <summary>Initialises a new embedded attachment from a name and in-memory content.</summary>
        /// <param name="sName">Display name of the attachment.</param>
        /// <param name="oContent">Raw file bytes embedded in the attachment.</param>
        /// <param name="eType">Attachment role; defaults to <see cref="ERPDocumentAttachmentType.Other"/>.</param>
        public ERPDocumentAttachment(String sName, Byte[] oContent, ERPDocumentAttachmentType eType = ERPDocumentAttachmentType.Other) :
            base(sName, oContent, ERPAttachmentMode.Embedded)
        {
            Type = eType;
        }

        /// <summary>Initialises a new URI-mode attachment that links to an external resource.</summary>
        /// <param name="sName">Display name of the attachment.</param>
        /// <param name="oURI">URI of the referenced resource.</param>
        /// <param name="eType">Attachment role; defaults to <see cref="ERPDocumentAttachmentType.Other"/>.</param>
        public ERPDocumentAttachment(String sName, Uri oURI, ERPDocumentAttachmentType eType = ERPDocumentAttachmentType.Other) :
            base(sName, oURI, ERPAttachmentMode.URI)
        {
            Type = eType;
        }

        /// <summary>Role this attachment plays for the document.</summary>
        public ERPDocumentAttachmentType Type { get; set; }
    }
}
