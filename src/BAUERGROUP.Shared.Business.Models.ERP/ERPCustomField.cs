using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A user-defined extension field carrying a code, name and string value.
    /// Extends <see cref="ERPCodeName"/> (which supplies <c>Code</c> and <c>Name</c>).
    /// </summary>
    public class ERPCustomField : ERPCodeName
    {
        /// <summary>Initialises an empty custom field.</summary>
        public ERPCustomField() :
            this(@"", @"", @"")
        {

        }

        /// <summary>Initialises a custom field from a code and value, with an empty name.</summary>
        public ERPCustomField(String sCode, String sValue) :
            this(sCode, @"", sValue)
        {

        }

        /// <summary>Initialises a custom field from a code, name and value.</summary>
        public ERPCustomField(String sCode, String sName, String sValue)
        {
            Code = sCode;
            Name = sName;
            Value = sValue;
        }

        /// <summary>Field value, stored as text.</summary>
        public String Value { get; set; }

        /// <summary>Initialises a custom field from a code and an integer value (stored as its string form).</summary>
        public ERPCustomField(String sCode, Int32 iValue) :
            this(sCode, iValue.ToString())
        {

        }

        /// <summary>Initialises a custom field from a code, name and an integer value (stored as its string form).</summary>
        public ERPCustomField(String sCode, String sName, Int32 iValue) :
            this(sCode, sName, iValue.ToString())
        {

        }
    }
}
