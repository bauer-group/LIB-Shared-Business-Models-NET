using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    /// <summary>
    /// Thrown when an expected shipping document cannot be found.
    /// </summary>
    public class ShippingDocumentNotFoundException : ShippingException
    {
        /// <summary>Initialises a new instance.</summary>
        public ShippingDocumentNotFoundException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ShippingDocumentNotFoundException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ShippingDocumentNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
