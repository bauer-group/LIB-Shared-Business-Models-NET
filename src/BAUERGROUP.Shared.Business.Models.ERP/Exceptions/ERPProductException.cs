using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPProductException : ERPException
    {
        public ERPProductException()
            : base()
        {
        }

        public ERPProductException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPProductException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
