using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A generic file attachment. Carries a display <see cref="Name"/> plus exactly one payload —
    /// a file path (<see cref="Filename"/>), inline bytes (<see cref="Content"/>) or an external
    /// <see cref="URI"/> — selected by <see cref="Mode"/>. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPAttachment : ERPObjectBase
    {
        /// <summary>Initialises an empty file-mode attachment (German language).</summary>
        public ERPAttachment() :
            this(@"", @"", ERPAttachmentMode.File)
        {

        }

        /// <summary>Initialises an empty attachment with the given storage <paramref name="eMode"/>.</summary>
        public ERPAttachment(ERPAttachmentMode eMode) :
            this(@"", @"", eMode)
        {

        }

        /// <summary>Initialises a file-path attachment from a name and filename.</summary>
        public ERPAttachment(String sName, String sFilename, ERPAttachmentMode eMode = ERPAttachmentMode.File, ERPLanguage eLanguage = null)
        {
            Name = sName;
            Filename = sFilename;
            Content = null;
            URI = null;
            Mode = eMode;
            Language = eLanguage ?? ERPLanguage.German;
        }

        /// <summary>Initialises an embedded attachment from a name and inline byte content.</summary>
        public ERPAttachment(String sName, Byte[] oContent, ERPAttachmentMode eMode = ERPAttachmentMode.Embedded, ERPLanguage eLanguage = null)
        {
            Name = sName;
            Filename = null;
            Content = oContent;
            URI = null;
            Mode = eMode;
            Language = eLanguage ?? ERPLanguage.German;
        }

        /// <summary>Initialises a URI-reference attachment from a name and external <see cref="Uri"/>.</summary>
        public ERPAttachment(String sName, Uri oURI, ERPAttachmentMode eMode = ERPAttachmentMode.URI, ERPLanguage eLanguage = null)
        {
            Name = sName;
            Filename = null;
            Content = null;
            URI = oURI;
            Mode = eMode;
            Language = eLanguage ?? ERPLanguage.German;
        }

        /// <summary>Display name of the attachment.</summary>
        public String Name { get; set; }

        /// <summary>File path or name of the referenced file (used when <see cref="Mode"/> is <see cref="ERPAttachmentMode.File"/>).</summary>
        public String Filename { get; set; }
        /// <summary>Inline byte payload (used when <see cref="Mode"/> is <see cref="ERPAttachmentMode.Embedded"/>).</summary>
        public Byte[] Content { get; set; }
        /// <summary>External resource location (used when <see cref="Mode"/> is <see cref="ERPAttachmentMode.URI"/>).</summary>
        public Uri URI { get; set; }

        /// <summary>Indicates which payload field carries the attachment.</summary>
        public ERPAttachmentMode Mode { get; set; }

        /// <summary>Language the attachment content is associated with.</summary>
        public ERPLanguage Language { get; set; }
    }
}
