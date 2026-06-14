using System;

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