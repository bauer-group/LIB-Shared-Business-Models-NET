using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    /// <summary>
    /// Thrown when an ERP argument is outside the range of permitted values. The ERP-domain
    /// parallel to <see cref="ArgumentOutOfRangeException"/>, whose constructors additionally
    /// accept the offending parameter name.
    /// </summary>
    public class ERPArgumentOutOfRangeException : ERPArgumentException
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPArgumentOutOfRangeException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPArgumentOutOfRangeException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPArgumentOutOfRangeException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
