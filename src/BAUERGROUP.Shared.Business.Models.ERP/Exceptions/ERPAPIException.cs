using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    /// <summary>
    /// Thrown when an ERP API call fails or returns an error.
    /// </summary>
    public class ERPAPIException : ERPException
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPAPIException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPAPIException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPAPIException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
