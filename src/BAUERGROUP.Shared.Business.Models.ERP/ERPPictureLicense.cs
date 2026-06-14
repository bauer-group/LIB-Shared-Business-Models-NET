using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPictureLicense
    {
        public ERPPictureLicense()
        {
            Licensor = ERPPictureLicensor.OwnCreation;
            LicensorIdentity = null;
            // ValidFrom/ValidTo null => unbounded validity (was Itenso TimeRange.Anytime).
        }

        public ERPPictureLicensor Licensor { get; set; }
        public ERPBusinessAssociate LicensorIdentity { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
