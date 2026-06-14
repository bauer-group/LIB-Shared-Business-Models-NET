using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProcessStep : ERPObjectBase
    {
        public ERPProcessStep()
        {
            Name = Description = @"";
            
            Todo = new ERPTodo();
            Document = new ERPDocument();
        }

        public String Name { get; set; }
        public String Description { get; set; }

        public ERPTodo Todo { get; set; }
        public ERPDocument Document { get; set; }        
    }
}
