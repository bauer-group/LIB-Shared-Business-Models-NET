using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPProductPictureUsage
    {
        None = 0,

        Preview = 2,

        Print = 4,
        Online = 8,

        Sublicensing = 16
    }
}
