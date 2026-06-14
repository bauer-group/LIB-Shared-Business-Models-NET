using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{    
    public class ERPInvalidDataException: ERPException
    {
        public ERPInvalidDataException()
            : base()
        {
        }

        public ERPInvalidDataException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPInvalidDataException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
