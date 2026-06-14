using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A status code paired with a human-readable detail message. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPStatusDetails: ERPObjectBase
    {
        /// <summary>Initialises a new instance with a zero code and empty message.</summary>
        public ERPStatusDetails()
        {
            Code = 0;
            Name = @"";
        }

        /// <summary>Numeric status code.</summary>
        public short Code { get; set; }
        /// <summary>Human-readable status message.</summary>
        public string Name { get; set; }
    }
}
