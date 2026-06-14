using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPPriority
    {
        VeryLow = -2,
        Low = -1,

        Normal = 0,
        
        High = 1,
        VeryHigh = 2,

        Critical = 3
    }
}
