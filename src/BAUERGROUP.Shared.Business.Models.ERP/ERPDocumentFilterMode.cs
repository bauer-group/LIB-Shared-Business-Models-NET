using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Selects which field an ERP document query filters on.
    /// </summary>
    public enum ERPDocumentFilterMode
    {
        /// <summary>No filter applied.</summary>
        None = 0,

        /// <summary>Filter by document unique identifier.</summary>
        UID = 1,
        Reference = 2,
        PartnersReference = 3,
        Status = 4,
        /// <summary>Filter by reference and status combined.</summary>
        ReferenceANDStatus = 5,
        Flag = 6,
        ShipmentInformation = 7,
        ShipmentStatus = 8,
        CustomField = 9
    }
}
