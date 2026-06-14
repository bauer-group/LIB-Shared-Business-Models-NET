using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    /// <summary>
    /// Thrown when the requested ERP product cannot be found. Carries the product
    /// <see cref="Reference"/> that was looked up.
    /// </summary>
    public class ERPProductNotFoundException : ERPProductException
    {
        /// <summary>Initialises a new instance with an empty <see cref="Reference"/>.</summary>
        public ERPProductNotFoundException()
            : base()
        {
            Reference = @"";
        }

        /// <summary>Initialises a new instance with the specified error message and an empty <see cref="Reference"/>.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        public ERPProductNotFoundException(string sMessage)
            : base(sMessage)
        {
            Reference = @"";
        }

        /// <summary>Initialises a new instance with an error message, the underlying cause and an empty <see cref="Reference"/>.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPProductNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
            Reference = @"";
        }

        /// <summary>Identifier of the product that could not be found.</summary>
        public String Reference { get; set; }

        /// <summary>Initialises a new instance with the specified error message and product reference.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="sReference">Identifier of the product that could not be found.</param>
        public ERPProductNotFoundException(string sMessage, string sReference)
            : base(sMessage)
        {
            Reference = sReference;
        }

        /// <summary>Initialises a new instance with an error message, product reference and the underlying cause.</summary>
        /// <param name="sMessage">The message that describes the error.</param>
        /// <param name="sReference">Identifier of the product that could not be found.</param>
        /// <param name="eInnerException">The exception that is the cause of this exception.</param>
        public ERPProductNotFoundException(string sMessage, string sReference, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
            Reference = sReference;
        }
    }
}
