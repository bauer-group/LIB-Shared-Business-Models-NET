using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    /// <summary>
    /// Thrown when an argument supplied to an ERP operation is invalid. The ERP-domain
    /// parallel to <see cref="ArgumentException"/>, whose constructors additionally accept
    /// the offending parameter name.
    /// </summary>
    public class ERPArgumentException : ERPException
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPArgumentException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPArgumentException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPArgumentException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {

        }
    }
}
