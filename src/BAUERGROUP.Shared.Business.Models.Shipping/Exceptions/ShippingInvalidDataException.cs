using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    public class ShippingInvalidDataException : ShippingException
    {
        public ShippingInvalidDataException()
            : base()
        {
        }

        public ShippingInvalidDataException(string sMessage)
            : base(sMessage)
        {
        }

        public ShippingInvalidDataException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
