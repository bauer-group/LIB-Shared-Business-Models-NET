using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A workflow / process chain over documents. Extends <see cref="ERPObjectBase"/> and
    /// groups an ordered collection of <see cref="ERPProcessStep"/> entries.
    /// </summary>
    public class ERPProcess : ERPObjectBase
    {
        /// <summary>Initialises a new process with neutral defaults and an empty step list.</summary>
        public ERPProcess()
        {
            Name = Description = @"";

            ProcessSteps = new List<ERPProcessStep>(0);
        }

        /// <summary>Display name of the process.</summary>
        public String Name { get; set; }
        /// <summary>Free-text description of the process.</summary>
        public String Description { get; set; }

        /// <summary>Ordered steps that make up the process.</summary>
        public List<ERPProcessStep> ProcessSteps { get; set; }
    }
}
