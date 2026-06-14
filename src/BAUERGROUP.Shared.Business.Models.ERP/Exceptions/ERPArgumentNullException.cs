using System;

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
