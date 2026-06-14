using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A localized text block for a product. Extends <see cref="ERPText"/> (name + language)
    /// and adds the description and notice fields.
    /// </summary>
    public class ERPProductText : ERPText
    {
        /// <summary>Initialises a new text block with neutral defaults.</summary>
        public ERPProductText() :
            base()
        {

        }

        /// <summary>Initialises a new text block with the given name and language.</summary>
        /// <param name="sName">Localized name.</param>
        /// <param name="eLanguage">Language of the text (<c>null</c> for the default language).</param>
        public ERPProductText(String sName = @"", ERPLanguage eLanguage = null)
            : base(sName, eLanguage)
        {
            Description = Notice = @"";
        }

        /// <summary>Localized description.</summary>
        public String Description { get; set; }
        /// <summary>Localized notice / remark.</summary>
        public String Notice { get; set; }
    }
}
