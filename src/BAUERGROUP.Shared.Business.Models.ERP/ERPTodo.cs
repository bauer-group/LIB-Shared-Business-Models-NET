using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPTodo : ERPObjectBase
    {
        public ERPTodo()
        {
            Subject = Description = @"";
            Modified = DateTime.UtcNow;
            Begin = Due = Reminder = null;
            Priority = ERPPriority.Normal;
            PercentDone = 0;
            Category = ERPDocumentFlags.None;
            Subscription = null;
            BusinessPartner = null;
        }

        public String Subject { get; set; }
        public String Description { get; set; }

        public DateTime Modified { get; set; }

        public DateTime? Begin { get; set; }
        public DateTime? Due { get; set; }
        public DateTime? Reminder { get; set; }
        public ERPPriority Priority { get; set; }

        public Byte PercentDone { get; set; }
        public Boolean IsDone { get { return PercentDone >= 100; } }

        public ERPDocumentFlags Category { get; set; }

        public ERPSubscription Subscription { get; set; }
        public ERPBusinessAssociate BusinessPartner { get; set; }
    }
}
