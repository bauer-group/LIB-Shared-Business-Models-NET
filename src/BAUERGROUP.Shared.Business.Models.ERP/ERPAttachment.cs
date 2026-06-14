using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPAttachment : ERPObjectBase
    {
        public ERPAttachment() :
            this(@"", @"", ERPAttachmentMode.File)
        {

        }

        public ERPAttachment(ERPAttachmentMode eMode) :
            this(@"", @"", eMode)
        {

        }

        public ERPAttachment(String sName, String sFilename, ERPAttachmentMode eMode = ERPAttachmentMode.File, ERPLanguage eLanguage = null)
        {
            Name = sName;
            Filename = sFilename;
            Content = null;
            URI = null;
            Mode = eMode;
            Language = eLanguage ?? ERPLanguage.German;
        }

        public ERPAttachment(String sName, Byte[] oContent, ERPAttachmentMode eMode = ERPAttachmentMode.Embedded, ERPLanguage eLanguage = null)
        {
            Name = sName;
            Filename = null;
            Content = oContent;
            URI = null;
            Mode = eMode;
            Language = eLanguage ?? ERPLanguage.German;
        }

        public ERPAttachment(String sName, Uri oURI, ERPAttachmentMode eMode = ERPAttachmentMode.URI, ERPLanguage eLanguage = null)
        {
            Name = sName;
            Filename = null;
            Content = null;
            URI = oURI;
            Mode = eMode;
            Language = eLanguage ?? ERPLanguage.German;
        }

        public String Name { get; set; }

        public String Filename { get; set; }
        public Byte[] Content { get; set; }
        public Uri URI { get; set; }

        public ERPAttachmentMode Mode { get; set; }

        public ERPLanguage Language { get; set; }
    }
}
