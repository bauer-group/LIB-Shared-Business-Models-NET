using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPNotSupportedException : ERPException
    {
        public ERPNotSupportedException()
            : base()
        {
        }

        public ERPNotSupportedException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPNotSupportedException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
