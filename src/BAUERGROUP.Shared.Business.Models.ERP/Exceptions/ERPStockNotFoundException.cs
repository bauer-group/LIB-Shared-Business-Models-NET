using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPStockNotFoundException : ERPStockException
    {
        public ERPStockNotFoundException()
            : base()
        {
        }

        public ERPStockNotFoundException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPStockNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
