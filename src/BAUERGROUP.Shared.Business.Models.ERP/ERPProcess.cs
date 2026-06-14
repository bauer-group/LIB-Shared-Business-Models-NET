using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProcess : ERPObjectBase
    {
        public ERPProcess()
        {
            Name = Description = @"";

            ProcessSteps = new List<ERPProcessStep>(0);
        }

        public String Name { get; set; }
        public String Description { get; set; }

        public List<ERPProcessStep> ProcessSteps { get; set; }
    }
}
