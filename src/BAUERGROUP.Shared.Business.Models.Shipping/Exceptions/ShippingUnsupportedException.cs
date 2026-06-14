using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingUnsupportedException : ShippingException
    {
        public ShippingUnsupportedException()
            : base()
        {
        }

        public ShippingUnsupportedException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingUnsupportedException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
