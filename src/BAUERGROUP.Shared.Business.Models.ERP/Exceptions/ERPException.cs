using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{    
    /// <summary>
    /// Base exception for all <c>ERP</c> domain failures.
    /// </summary>
    public class ERPException : Exception
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
