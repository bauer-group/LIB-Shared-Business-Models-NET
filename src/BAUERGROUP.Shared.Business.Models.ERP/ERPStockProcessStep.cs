using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A single step within an <see cref="ERPStockProcessChain"/>. Extends
    /// <see cref="ERPCodeName"/>, carrying a code/name identity for the step.
    /// </summary>
    public class ERPStockProcessStep : ERPCodeName
    {
        /// <summary>Initialises a new process step with neutral defaults.</summary>
        public ERPStockProcessStep()
        {
            
        }
    }
}
