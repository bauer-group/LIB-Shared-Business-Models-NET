using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPPaymentType
    {
        Other = -1,

        Unspecified = 0,

        WireTransfer = 1,

        CreditCard = 2,
        DebitCard = 3,

        DirectDebit = 4,

        Cash = 5,
        CashOnDelivery = 6,

        NoInvoicing = 1000
    }
}
