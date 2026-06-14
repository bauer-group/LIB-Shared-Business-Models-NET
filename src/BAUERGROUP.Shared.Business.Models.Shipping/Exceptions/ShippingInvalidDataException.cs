using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    /// <summary>
    /// Thrown when shipping input data fails validation.
    /// </summary>
    public class ShippingInvalidDataException : ShippingException
    {
        /// <summary>Initialises a new instance.</summary>
        public ShippingInvalidDataException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ShippingInvalidDataException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ShippingInvalidDataException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
