using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
