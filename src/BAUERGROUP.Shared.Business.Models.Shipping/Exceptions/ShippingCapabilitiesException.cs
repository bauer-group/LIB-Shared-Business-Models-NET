using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    /// <summary>
    /// Thrown when a requested shipping capability is not supported by the carrier or provider.
    /// </summary>
    public class ShippingCapabilitiesException : ShippingException
    {
        /// <summary>Initialises a new instance.</summary>
        public ShippingCapabilitiesException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ShippingCapabilitiesException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ShippingCapabilitiesException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
