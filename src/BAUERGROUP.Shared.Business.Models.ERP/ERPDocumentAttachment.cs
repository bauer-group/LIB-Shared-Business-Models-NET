using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDocumentAttachment : ERPAttachment
    {
        public ERPDocumentAttachment() :
            base(ERPAttachmentMode.File)
        {            
            Type = ERPDocumentAttachmentType.Other;            
        }

        public ERPDocumentAttachment(String sName, String sFilename, ERPDocumentAttachmentType eType = ERPDocumentAttachmentType.Other):
            base(sName, sFilename, ERPAttachmentMode.File)
        {
            Type = eType;            
        }

        public ERPDocumentAttachment(String sName, Byte[] oContent, ERPDocumentAttachmentType eType = ERPDocumentAttachmentType.Other) :
            base(sName, oContent, ERPAttachmentMode.Embedded)
        {
            Type = eType;
        }

        public ERPDocumentAttachment(String sName, Uri oURI, ERPDocumentAttachmentType eType = ERPDocumentAttachmentType.Other) :
            base(sName, oURI, ERPAttachmentMode.URI)
        {
            Type = eType;
        }

        public ERPDocumentAttachmentType Type { get; set; }
    }
}
