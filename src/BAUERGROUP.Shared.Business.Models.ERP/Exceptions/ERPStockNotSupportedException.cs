using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPStockNotSupportedException: ERPStockException
    {
        public ERPStockNotSupportedException()
            : base()
        {
        }

        public ERPStockNotSupportedException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPStockNotSupportedException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
