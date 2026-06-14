using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{    
    public class ERPException : Exception
    {
        public ERPException()
            : base()
        {
        }

        public ERPException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
