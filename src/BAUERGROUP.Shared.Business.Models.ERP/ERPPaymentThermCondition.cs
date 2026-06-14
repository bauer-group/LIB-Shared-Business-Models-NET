using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A single tier of a payment-terms schedule (a payment deadline). Extends
    /// <see cref="ERPObjectBase"/> and pairs a due period with an optional cash discount.
    /// </summary>
    public class ERPPaymentThermCondition : ERPObjectBase
    {
        /// <summary>Initialises a new condition with zero days and no cash discount.</summary>
        public ERPPaymentThermCondition() :
            this (0, 0m)
        {

        }

        /// <summary>Initialises a new condition with a due period in days and a cash discount.</summary>
        /// <param name="bDays">Number of days until due.</param>
        /// <param name="dCashDiscount">Cash discount granted within the period.</param>
        public ERPPaymentThermCondition(Byte bDays, Decimal dCashDiscount) :
            this (bDays, dCashDiscount, 0m)
        {

        }

        /// <summary>Initialises a new condition with a due period and a cash discount.</summary>
        /// <param name="tsDays">Period until due.</param>
        /// <param name="dCashDiscount">Cash discount granted within the period.</param>
        public ERPPaymentThermCondition(TimeSpan tsDays, Decimal dCashDiscount) :
            this(tsDays, dCashDiscount, 0m)
        {

        }

        /// <summary>Initialises a new condition with a due period in days, cash discount and payment amount.</summary>
        /// <param name="bDays">Number of days until due.</param>
        /// <param name="dCashDiscount">Cash discount granted within the period.</param>
        /// <param name="dPaymentAmount">Payment amount due for this tier, in the object's currency.</param>
        public ERPPaymentThermCondition(Byte bDays, Decimal dCashDiscount, Decimal dPaymentAmount) :
            this(new TimeSpan(bDays, 0, 0, 0), dCashDiscount, dPaymentAmount)
        {

        }

        /// <summary>Initialises a new condition with a due period, cash discount and payment amount.</summary>
        /// <param name="tsDays">Period until due.</param>
        /// <param name="dCashDiscount">Cash discount granted within the period.</param>
        /// <param name="dPaymentAmount">Payment amount due for this tier, in the object's currency.</param>
        public ERPPaymentThermCondition(TimeSpan tsDays, Decimal dCashDiscount, Decimal dPaymentAmount) :
            this(tsDays, dCashDiscount, dPaymentAmount, ERPPaymentType.Unspecified)
        {

        }

        /// <summary>Initialises a new condition with a due period, cash discount, payment amount and method.</summary>
        /// <param name="tsDays">Period until due.</param>
        /// <param name="dCashDiscount">Cash discount granted within the period.</param>
        /// <param name="dPaymentAmount">Payment amount due for this tier, in the object's currency.</param>
        /// <param name="eType">Payment method for this tier.</param>
        public ERPPaymentThermCondition(TimeSpan tsDays, Decimal dCashDiscount, Decimal dPaymentAmount, ERPPaymentType eType)
        {
            Days = tsDays;
            CashDiscount = dCashDiscount;
            PaymentAmount = dPaymentAmount;
            Method = eType;
        }

        /// <summary>Period until the payment is due.</summary>
        public TimeSpan Days { get; set; }
        /// <summary>Cash discount granted when paying within <see cref="Days"/>.</summary>
        public Decimal CashDiscount { get; set; }
        /// <summary>Payment amount due for this tier, in the object's currency.</summary>
        public Decimal PaymentAmount { get; set; }
        /// <summary>Payment method for this tier.</summary>
        public ERPPaymentType Method { get; set; }
    }
}
