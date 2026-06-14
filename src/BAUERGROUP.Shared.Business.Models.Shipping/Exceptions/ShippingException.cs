using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping.Exceptions
{
    /// <summary>
    /// Base exception for all <c>Shipping</c> domain failures. Derived types signal specific
    /// failure conditions (unsupported capabilities, missing documents, print failures,
    /// invalid data, bad parameters, unsupported operations).
    /// </summary>
    public class ShippingException : Exception
    {
        /// <summary>Initialises a new instance.</summary>
        public ShippingException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ShippingException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ShippingException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
