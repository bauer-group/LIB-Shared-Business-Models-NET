using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingDocumentsPrintException : ShippingException
    {
        public ShippingDocumentsPrintException()
            : base()
        {
        }

        public ShippingDocumentsPrintException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingDocumentsPrintException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
