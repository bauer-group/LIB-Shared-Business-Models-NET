using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A recurring subscription document. Extends <see cref="ERPDocument"/> and adds the recurrence
    /// window and interval on top of the standard document surface.
    /// </summary>
    public class ERPSubscription: ERPDocument
    {
        /// <summary>Initialises a new instance enabled, with a 30-day interval and no start/stop bounds.</summary>
        public ERPSubscription()
            : base()
        {
            SubscriptionEnabled = true;
            SubscriptionInterval = TimeSpan.FromDays(30);
            SubscriptionStart = null;
            SubscriptionStop = null;
        }

        /// <summary>First date the subscription runs (<c>null</c> = no defined start).</summary>
        public DateTime? SubscriptionStart { get; set; }
        /// <summary>Last date the subscription runs (<c>null</c> = open-ended).</summary>
        public DateTime? SubscriptionStop { get; set; }
        /// <summary>Recurrence interval between subscription runs (defaults to 30 days).</summary>
        public TimeSpan SubscriptionInterval { get; set; }
        /// <summary>Whether the subscription is currently active.</summary>
        public Boolean SubscriptionEnabled { get; set; }

        /*
         * Hints:
         * - Day of Month; first, last Day, Day of Week
         * - Depends on Qty of Items
         * - Depends on Month with Qty Options
         */
    }
}
