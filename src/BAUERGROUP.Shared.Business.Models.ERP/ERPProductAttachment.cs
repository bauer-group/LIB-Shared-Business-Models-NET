using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductAttachment : ERPAttachment
    {
        public ERPProductAttachment() :
            base(ERPAttachmentMode.Embedded)
        {
            Type = ERPProductAttachmentType.Other;            
        }

        public ERPProductAttachment(string sName, string sFilename, ERPProductAttachmentType eType = ERPProductAttachmentType.Other) :
            base(sName, sFilename, ERPAttachmentMode.File)
        {
            Type = eType;            
        }

        public ERPProductAttachmentType Type { get; set; }
    }
}
