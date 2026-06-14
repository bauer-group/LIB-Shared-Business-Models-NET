using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{    
    /// <summary>
    /// Thrown when ERP input data fails validation or is otherwise invalid.
    /// </summary>
    public class ERPInvalidDataException: ERPException
    {
        /// <summary>Initialises a new instance.</summary>
        public ERPInvalidDataException()
            : base()
        {
        }

        /// <summary>Initialises a new instance with the specified error message.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPInvalidDataException(string sMessage)
            : base(sMessage)
        {
        }

        /// <summary>Initialises a new instance with an error message and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPInvalidDataException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
