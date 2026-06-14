using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A sales representative. Extends <see cref="ERPObjectBase"/> with a <see cref="Code"/>,
    /// <see cref="Name"/> and free-text <see cref="Description"/>.
    /// </summary>
    public class ERPCommercialRepresentative : ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty code, name and description.</summary>
        public ERPCommercialRepresentative()
        {
            Code = Name = Description = @"";
        }

        /// <summary>Short lookup code for the representative.</summary>
        public string Code { get; set; }
        /// <summary>Display name of the representative.</summary>
        public string Name { get; set; }
        /// <summary>Free-text description.</summary>
        public string Description { get; set; }
    }
}
