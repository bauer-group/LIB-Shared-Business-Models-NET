using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPProductNotSupportedException: ERPProductException
    {
        public ERPProductNotSupportedException()
            : base()
        {
        }

        public ERPProductNotSupportedException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPProductNotSupportedException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
