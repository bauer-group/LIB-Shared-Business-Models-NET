using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A single step within an <see cref="ERPProcess"/> workflow chain. Extends
    /// <see cref="ERPObjectBase"/> and binds a task and a document to the step.
    /// </summary>
    public class ERPProcessStep : ERPObjectBase
    {
        /// <summary>Initialises a new step with neutral defaults and empty task / document.</summary>
        public ERPProcessStep()
        {
            Name = Description = @"";

            Todo = new ERPTodo();
            Document = new ERPDocument();
        }

        /// <summary>Display name of the step.</summary>
        public String Name { get; set; }
        /// <summary>Free-text description of the step.</summary>
        public String Description { get; set; }

        /// <summary>Task associated with this step.</summary>
        public ERPTodo Todo { get; set; }
        /// <summary>Document this step operates on.</summary>
        public ERPDocument Document { get; set; }
    }
}
