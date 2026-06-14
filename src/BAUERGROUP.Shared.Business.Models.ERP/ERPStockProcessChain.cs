using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An ordered set of warehouse process steps forming a stock-handling chain. Extends
    /// <see cref="ERPCodeName"/>, carrying a code/name identity, and maps each
    /// <see cref="ERPStockProcessStep"/> to the bin location at which it is performed.
    /// </summary>
    public class ERPStockProcessChain : ERPCodeName
    {
        /// <summary>Initialises a new process chain with an empty step map.</summary>
        public ERPStockProcessChain()
        {
            Steps = new Dictionary<ERPStockProcessStep, ERPStockBinLocation>(0);
        }

        /// <summary>Steps of the chain, each keyed to the <see cref="ERPStockBinLocation"/> where it takes place.</summary>
        public Dictionary<ERPStockProcessStep, ERPStockBinLocation> Steps { get; set; }
    }
}
