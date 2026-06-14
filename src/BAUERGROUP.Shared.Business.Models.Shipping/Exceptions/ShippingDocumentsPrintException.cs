using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    /// <summary>
    /// Thrown when printing one or more shipping documents fails.
    /// </summary>
    public class ShippingDocumentsPrintException : ShippingException
    {
        /// <summary>Initialises a new instance.</summary>
        public ShippingDocumentsPrintException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ShippingDocumentsPrintException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ShippingDocumentsPrintException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
