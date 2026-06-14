using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPSubscription: ERPDocument
    {
        public ERPSubscription()
            : base()
        {
            SubscriptionEnabled = true;
            SubscriptionInterval = TimeSpan.FromDays(30);
            SubscriptionStart = null;
            SubscriptionStop = null;
        }

        public DateTime? SubscriptionStart { get; set; }
        public DateTime? SubscriptionStop { get; set; }
        public TimeSpan SubscriptionInterval { get; set; }
        public Boolean SubscriptionEnabled { get; set; }

        /*
         * Hints:
         * - Day of Month; first, last Day, Day of Week
         * - Depends on Qty of Items
         * - Depends on Month with Qty Options
         */
    }
}
