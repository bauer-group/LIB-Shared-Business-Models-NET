using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A named payment-terms definition. Extends <see cref="ERPObjectBase"/> and holds the
    /// schedule of <see cref="ERPPaymentThermCondition"/> deadlines that make up the terms.
    /// </summary>
    public class ERPPaymentTherms : ERPObjectBase
    {
        /// <summary>Initialises new payment terms with neutral defaults and an empty deadline schedule.</summary>
        public ERPPaymentTherms()
        {
            Name = Description = @"";
            PaymentDeadline = new List<ERPPaymentThermCondition>(0);
        }

        /// <summary>Display name of the payment terms.</summary>
        public String Name { get; set; }
        /// <summary>Free-text description of the payment terms.</summary>
        public String Description { get; set; }
        /// <summary>Schedule of payment deadlines (tiers) that make up the terms.</summary>
        public List<ERPPaymentThermCondition> PaymentDeadline { get; set; }
    }
}
