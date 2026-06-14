using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPArgumentException : ERPException
    {
        public ERPArgumentException()
            : base()
        {
        }

        public ERPArgumentException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPArgumentException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {

        }
    }
}
