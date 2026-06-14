using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPStockException : ERPException
    {
        public ERPStockException()
            : base()
        {
        }

        public ERPStockException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPStockException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
