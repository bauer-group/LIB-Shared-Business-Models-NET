using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPPictureLicensor
    {
        OwnCreation = -1,

        Supplier = 10,
        Manufacturer = 20,
        Importer = 30,

        ThirdParty = 50
    }
}
