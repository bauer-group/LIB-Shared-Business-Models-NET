using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPicture : ERPObjectBase
    {
        public ERPPicture()
        {            
            Name = null;
            Description = null;

            IsActive = true;

            Url = null;

            Details = new ERPPictureDetails();

            License = new ERPPictureLicense();
        }

        public String Name { get; set; }
        public String Description { get; set; }

        public Boolean IsActive { get; set; }

        public String Url { get; set; }

        public ERPPictureDetails Details { get; set; }

        public ERPPictureLicense License { get; set; }
    }
}
