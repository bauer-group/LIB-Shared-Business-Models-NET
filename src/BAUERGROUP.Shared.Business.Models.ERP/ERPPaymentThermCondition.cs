using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPaymentThermCondition : ERPObjectBase
    {
        public ERPPaymentThermCondition() : 
            this (0, 0m)
        {

        }

        public ERPPaymentThermCondition(Byte bDays, Decimal dCashDiscount) :
            this (bDays, dCashDiscount, 0m)
        {
            
        }

        public ERPPaymentThermCondition(TimeSpan tsDays, Decimal dCashDiscount) :
            this(tsDays, dCashDiscount, 0m)
        {
            
        }

        public ERPPaymentThermCondition(Byte bDays, Decimal dCashDiscount, Decimal dPaymentAmount) :
            this(new TimeSpan(bDays, 0, 0, 0), dCashDiscount, dPaymentAmount)
        {

        }

        public ERPPaymentThermCondition(TimeSpan tsDays, Decimal dCashDiscount, Decimal dPaymentAmount) :
            this(tsDays, dCashDiscount, dPaymentAmount, ERPPaymentType.Unspecified)
        {

        }

        public ERPPaymentThermCondition(TimeSpan tsDays, Decimal dCashDiscount, Decimal dPaymentAmount, ERPPaymentType eType)
        {
            Days = tsDays;
            CashDiscount = dCashDiscount;
            PaymentAmount = dPaymentAmount;
            Method = eType;
        }

        public TimeSpan Days { get; set; }
        public Decimal CashDiscount { get; set; }
        public Decimal PaymentAmount { get; set; }
        public ERPPaymentType Method { get; set; }
    }
}
