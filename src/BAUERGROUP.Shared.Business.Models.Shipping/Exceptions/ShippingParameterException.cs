using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingParameterException : ShippingException
    {
        public ShippingParameterException()
            : base()
        {
        }

        public ShippingParameterException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingParameterException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
