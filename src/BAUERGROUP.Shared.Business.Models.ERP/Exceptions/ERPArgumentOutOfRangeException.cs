using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPArgumentOutOfRangeException : ERPArgumentException
    {
        public ERPArgumentOutOfRangeException()
            : base()
        {
        }

        public ERPArgumentOutOfRangeException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPArgumentOutOfRangeException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
