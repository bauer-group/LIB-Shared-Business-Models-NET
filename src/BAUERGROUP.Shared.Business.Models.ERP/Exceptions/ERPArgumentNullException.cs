using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPArgumentNullException : ERPArgumentException
    {
        public ERPArgumentNullException()
            : base()
        {
        }

        public ERPArgumentNullException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPArgumentNullException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {

        }
    }
}
