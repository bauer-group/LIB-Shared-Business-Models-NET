using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPBusinessAssociateAttachment : ERPAttachment
    {
        public ERPBusinessAssociateAttachment() :
            base(ERPAttachmentMode.File)
        {
            Type = ERPBusinessAssociateAttachmentType.Other;
        }

        public ERPBusinessAssociateAttachment(string sName, string sFilename, ERPBusinessAssociateAttachmentType eType = ERPBusinessAssociateAttachmentType.Other) :
            base(sName, sFilename, ERPAttachmentMode.File)
        {
            Type = eType;
        }

        public ERPBusinessAssociateAttachmentType Type { get; set; }
    }
}
