using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    /// <summary>
    /// Thrown when a shipping operation is supplied with an invalid or missing parameter.
    /// </summary>
    public class ShippingParameterException : ShippingException
    {
        /// <summary>Initialises a new instance.</summary>
        public ShippingParameterException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ShippingParameterException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ShippingParameterException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
