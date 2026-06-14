using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A language-tagged text block. Extends <see cref="ERPObjectBase"/> and pairs a text value with
    /// the <see cref="ERPLanguage"/> it is written in.
    /// </summary>
    public class ERPText : ERPObjectBase
    {
        /// <summary>Initialises a new instance with the given text, defaulting the language to <see cref="ERPLanguage.German"/>.</summary>
        /// <param name="sName">The text value.</param>
        /// <param name="eLanguage">Language of the text; <c>null</c> falls back to <see cref="ERPLanguage.German"/>.</param>
        public ERPText(String sName = @"", ERPLanguage eLanguage = null)
        {
            Language = eLanguage ?? ERPLanguage.German;
            Name = sName;
        }

        /// <summary>Language the text is written in.</summary>
        public ERPLanguage Language { get; set; }
        /// <summary>The text value.</summary>
        public String Name { get; set; }
    }
}
