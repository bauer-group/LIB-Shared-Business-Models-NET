using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductPicture : ERPPicture
    {
        public ERPProductPicture()
        {
            Useage = ERPProductPictureUsage.Preview | ERPProductPictureUsage.Print | ERPProductPictureUsage.Online;
        }

        public ERPProductPictureUsage Useage { get; set; }           
    }
}
