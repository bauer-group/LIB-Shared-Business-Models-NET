using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// State of a single payment (booking). Extends <see cref="ERPObjectBase"/> and records the
    /// booked amount, value / booking dates, method and the counterparty bank account.
    /// </summary>
    public class ERPPaymentStatus : ERPObjectBase
    {
        /// <summary>Initialises a new payment status with neutral defaults (no dates, zero amount).</summary>
        public ERPPaymentStatus()
        {
            BookingReference = @"";
            PaymentReference = @"";
            ValueDate = null;
            BookingDate = null;
            Amount = 0m;
            Method = ERPPaymentType.Unspecified;
            PartnerAccount = null;
        }

        /// <summary>Bank booking reference.</summary>
        public string BookingReference { get; set; }
        /// <summary>Payment reference (e.g. remittance / purpose text).</summary>
        public string PaymentReference { get; set; }

        /// <summary>Value date of the payment (<c>null</c> if not set).</summary>
        public DateTime? ValueDate { get; set; }
        /// <summary>Booking date of the payment (<c>null</c> if not set).</summary>
        public DateTime? BookingDate { get; set; }

        /// <summary>Booked amount, in the object's currency.</summary>
        public decimal Amount { get; set; }

        /// <summary>Payment method used.</summary>
        public ERPPaymentType Method { get; set; }
        /// <summary>Counterparty bank account (<c>null</c> if not set).</summary>
        public ERPBankAccount PartnerAccount { get; set; }
    }
}
