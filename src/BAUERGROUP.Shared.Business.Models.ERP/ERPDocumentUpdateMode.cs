using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Selects which part of an ERP document an update operation writes back.
    /// </summary>
    public enum  ERPDocumentUpdateMode
    {
        /// <summary>Update the entire document.</summary>
        All = 0,
        /// <summary>Update only the processing status.</summary>
        Status = 1,
        /// <summary>Update only the shipping information.</summary>
        ShippingInformation = 2,
        /// <summary>Update only the shipping status.</summary>
        ShippingStatus = 3
    }
}
