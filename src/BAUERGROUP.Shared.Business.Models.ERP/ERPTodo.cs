using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A task or reminder. Extends <see cref="ERPObjectBase"/> and tracks scheduling, priority,
    /// progress and the related business partner.
    /// </summary>
    public class ERPTodo : ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty text, normal priority and zero progress.</summary>
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

        /// <summary>Short title of the task.</summary>
        public String Subject { get; set; }
        /// <summary>Detailed description of the task.</summary>
        public String Description { get; set; }

        /// <summary>Timestamp of the last modification (UTC).</summary>
        public DateTime Modified { get; set; }

        /// <summary>Scheduled start of the task (<c>null</c> if unset).</summary>
        public DateTime? Begin { get; set; }
        /// <summary>Due date of the task (<c>null</c> if unset).</summary>
        public DateTime? Due { get; set; }
        /// <summary>Reminder time for the task (<c>null</c> if none).</summary>
        public DateTime? Reminder { get; set; }
        /// <summary>Priority of the task.</summary>
        public ERPPriority Priority { get; set; }

        /// <summary>Completion progress in percent (0–100).</summary>
        public Byte PercentDone { get; set; }
        /// <summary>Whether the task is complete (<see cref="PercentDone"/> at or above 100).</summary>
        public Boolean IsDone { get { return PercentDone >= 100; } }

        /// <summary>Categorisation flags for the task.</summary>
        public ERPDocumentFlags Category { get; set; }

        /// <summary>Optional subscription that generated or recurs this task.</summary>
        public ERPSubscription Subscription { get; set; }
        /// <summary>Business partner the task relates to.</summary>
        public ERPBusinessAssociate BusinessPartner { get; set; }
    }
}
