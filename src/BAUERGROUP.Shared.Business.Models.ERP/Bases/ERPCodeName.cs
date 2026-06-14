using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases
{
    /// <summary>
    /// Base for code+name lookup types. Extends <see cref="ERPObjectBase"/> with a short
    /// <see cref="Code"/> and a human-readable <see cref="Name"/>.
    /// </summary>
    public class ERPCodeName : ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty code and name.</summary>
        public ERPCodeName()
            : this(String.Empty, String.Empty)
        {

        }

        /// <summary>Initialises a new instance with the specified code and name.</summary>
        /// <param name="sCode">The lookup code.</param>
        /// <param name="sName">The display name.</param>
        public ERPCodeName(String sCode, String sName)
		{
            Code = sCode;
            Name = sName;
		}

        /// <summary>Short lookup code.</summary>
        public String Code { get; set; }
        /// <summary>Human-readable display name.</summary>
        public String Name { get; set; }
    }
}
