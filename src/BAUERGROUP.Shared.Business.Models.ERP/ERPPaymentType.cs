using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Method by which a payment is made or settled.
    /// </summary>
    public enum ERPPaymentType
    {
        /// <summary>A method that does not fit the predefined types.</summary>
        Other = -1,

        /// <summary>Payment method not recorded.</summary>
        Unspecified = 0,

        WireTransfer = 1,

        CreditCard = 2,
        DebitCard = 3,

        DirectDebit = 4,

        Cash = 5,
        CashOnDelivery = 6,

        /// <summary>No invoicing / settlement applies.</summary>
        NoInvoicing = 1000
    }
}
