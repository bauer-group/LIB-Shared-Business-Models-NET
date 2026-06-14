using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A coded handling instruction. Extends <see cref="ERPCodeName"/> (code + name pair)
    /// and records when the instruction applies via <see cref="ERPProcessingInstructionMode"/>.
    /// </summary>
    public class ERPProcessingInstruction : ERPCodeName
    {
        /// <summary>Initialises a new instruction with empty code / name and <see cref="ERPProcessingInstructionMode.None"/>.</summary>
        public ERPProcessingInstruction()
            : this(String.Empty, String.Empty)
        {

        }

        /// <summary>Initialises a new instruction with the given code, name and application mode.</summary>
        /// <param name="sCode">Instruction code.</param>
        /// <param name="sName">Instruction name.</param>
        /// <param name="eMode">When the instruction applies; defaults to <see cref="ERPProcessingInstructionMode.None"/>.</param>
        public ERPProcessingInstruction(String sCode, String sName, ERPProcessingInstructionMode eMode = ERPProcessingInstructionMode.None)
            : base (sCode, sName)
        {
            Mode = eMode;
        }

        /// <summary>When the instruction applies relative to processing (before, after, both or none).</summary>
        public ERPProcessingInstructionMode Mode { get; set; }
    }
}
