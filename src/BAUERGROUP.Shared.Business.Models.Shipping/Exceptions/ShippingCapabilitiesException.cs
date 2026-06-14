using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingCapabilitiesException : ShippingException
    {
        public ShippingCapabilitiesException()
            : base()
        {
        }

        public ShippingCapabilitiesException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingCapabilitiesException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
