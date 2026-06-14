using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPProcessingInstructionMode
    {
        None = 0,
        
        Before = 1,
        After = 2,

        All = Before | After
    }
}