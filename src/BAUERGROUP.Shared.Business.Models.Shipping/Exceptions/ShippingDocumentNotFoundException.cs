using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingDocumentNotFoundException : ShippingException
    {
        public ShippingDocumentNotFoundException()
            : base()
        {
        }

        public ShippingDocumentNotFoundException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingDocumentNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
