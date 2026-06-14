using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentFilterMode
    {
        None = 0,

        UID = 1,
        Reference = 2,
        PartnersReference = 3,
        Status = 4,
        ReferenceANDStatus = 5,
        Flag = 6,
        ShipmentInformation = 7,
        ShipmentStatus = 8,
        CustomField = 9
    }
}
