using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Identifies an editor / author together with their contact details, for audit purposes.
    /// Extends <see cref="ERPCodeName"/> (which supplies <c>Code</c> and <c>Name</c>).
    /// </summary>
    public class ERPEditor : ERPCodeName
    {
        /// <summary>Initialises an editor with empty contact fields and German as the language.</summary>
        public ERPEditor()
        {
            Phone = Fax = EMail = Description = @"";

            Language = ERPLanguage.German;

            CustomFields = new List<ERPCustomField>(0);
        }

        /// <summary>Phone number of the editor.</summary>
        public String Phone { get; set; }
        /// <summary>Fax number of the editor.</summary>
        public String Fax { get; set; }
        /// <summary>E-mail address of the editor.</summary>
        public String EMail { get; set; }
        /// <summary>Free-text description / note about the editor.</summary>
        public String Description { get; set; }

        /// <summary>Preferred language of the editor.</summary>
        public ERPLanguage Language { get; set; }

        /// <summary>User-defined extension fields attached to the editor.</summary>
        public List<ERPCustomField> CustomFields { get; set; }
    }
}
