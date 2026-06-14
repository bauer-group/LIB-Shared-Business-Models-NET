using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPWorkflow : ERPObjectBase
    {
        public ERPWorkflow()
        {
            Subject = Description = @"";
            Modified = DateTime.UtcNow;
        }

        public String Subject { get; set; }
        public String Description { get; set; }

        public DateTime Modified { get; set; }

        //Purpose: Automation Workflows
        //Incomplete Class
        /*
         * Missing Objects:
         * - Event Date/Time, Create, Update, Cancel, Edit, Forward, ... Document
         * - Condition Price, Product, Date/Time, Weekday, Stock Balance, Reserved Qty, ...
         * - Action(s) Create, Update, Copy, Forward, Cancel ... Document // Print, Mail, Save PDF/Form // Call Webhook, API, Request GET/POST/PUT // Send Mail         
         * - Error Handler
         */
    }
}
