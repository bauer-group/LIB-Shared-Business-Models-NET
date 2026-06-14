using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

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
