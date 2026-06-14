using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    /// <summary>
    /// Thrown when a required ERP argument is <c>null</c>. The ERP-domain parallel to
    /// <see cref="ArgumentNullException"/>, whose constructors additionally accept the
    /// offending parameter name.
    /// </summary>
    public class ERPArgumentNullException : ERPArgumentException
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPArgumentNullException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPArgumentNullException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPArgumentNullException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {

        }
    }
}
