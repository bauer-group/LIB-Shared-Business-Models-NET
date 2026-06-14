using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPObjectStatus
    {
        None = 0,

        Obsolete = 2,
        Cancelled = 4,
        Draft = 8,
        Continued = 16,
        Disabled = 32,

        Booked = 64,

        Deleted = 128
    }
}
