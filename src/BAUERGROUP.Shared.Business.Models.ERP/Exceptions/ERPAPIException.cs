using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPAPIException : ERPException
    {
        public ERPAPIException()
            : base()
        {
        }

        public ERPAPIException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPAPIException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
