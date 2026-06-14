using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An automation workflow definition. Extends <see cref="ERPObjectBase"/>. Currently carries only
    /// the descriptive header; event, condition and action members are not yet modelled.
    /// </summary>
    public class ERPWorkflow : ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty text and the current UTC modification time.</summary>
        public ERPWorkflow()
        {
            Subject = Description = @"";
            Modified = DateTime.UtcNow;
        }

        /// <summary>Short title of the workflow.</summary>
        public String Subject { get; set; }
        /// <summary>Detailed description of the workflow.</summary>
        public String Description { get; set; }

        /// <summary>Timestamp of the last modification (UTC).</summary>
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
