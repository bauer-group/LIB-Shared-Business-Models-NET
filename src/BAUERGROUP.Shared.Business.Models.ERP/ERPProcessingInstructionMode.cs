using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// When a processing instruction applies relative to the processing step. Flags enum.
    /// </summary>
    [Flags]
    public enum ERPProcessingInstructionMode
    {
        /// <summary>Instruction does not apply.</summary>
        None = 0,

        /// <summary>Applies before processing.</summary>
        Before = 1,
        /// <summary>Applies after processing.</summary>
        After = 2,

        /// <summary>Applies both before and after processing (<see cref="Before"/> | <see cref="After"/>).</summary>
        All = Before | After
    }
}