using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPaymentTherms : ERPObjectBase
    {
        public ERPPaymentTherms()
        {
            Name = Description = @"";
            PaymentDeadline = new List<ERPPaymentThermCondition>(0);
        }

        public String Name { get; set; }
        public String Description { get; set; }
        public List<ERPPaymentThermCondition> PaymentDeadline { get; set; }        
    }
}
