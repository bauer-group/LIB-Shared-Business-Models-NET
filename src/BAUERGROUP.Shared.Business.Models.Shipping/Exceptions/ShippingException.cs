using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingException : Exception
    {
        public ShippingException()
            : base()
        {
        }

        public ShippingException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
