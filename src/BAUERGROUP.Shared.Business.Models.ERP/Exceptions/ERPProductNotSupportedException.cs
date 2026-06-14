using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    /// <summary>
    /// Thrown when the ERP product or product type is not supported.
    /// </summary>
    public class ERPProductNotSupportedException: ERPProductException
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPProductNotSupportedException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPProductNotSupportedException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPProductNotSupportedException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
