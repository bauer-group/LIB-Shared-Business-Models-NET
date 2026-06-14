using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Usage roles a product picture may be used for, combinable as bit flags.
    /// </summary>
    [Flags]
    public enum ERPProductPictureUsage
    {
        /// <summary>No usage permitted.</summary>
        None = 0,

        Preview = 2,

        Print = 4,
        Online = 8,

        /// <summary>May be sublicensed to third parties.</summary>
        Sublicensing = 16
    }
}
