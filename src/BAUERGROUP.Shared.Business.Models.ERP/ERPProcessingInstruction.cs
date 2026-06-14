using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProcessingInstruction : ERPCodeName
    {
        public ERPProcessingInstruction()
            : this(String.Empty, String.Empty)
        {

        }

        public ERPProcessingInstruction(String sCode, String sName, ERPProcessingInstructionMode eMode = ERPProcessingInstructionMode.None)
            : base (sCode, sName)
        {
            Mode = eMode;
        }

        public ERPProcessingInstructionMode Mode { get; set; }
    }
}
