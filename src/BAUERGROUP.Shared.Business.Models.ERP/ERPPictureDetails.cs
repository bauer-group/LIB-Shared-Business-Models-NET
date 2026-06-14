using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPictureDetails
    {
        public ERPPictureDetails()
        {
            ImageCreated = null;
            ImageChanged = null;

            ImageSize = 0;
            Width = 0;
            Height = 0;

            ImageType = @"application/octet-stream";
        }

        public DateTime? ImageCreated { get; set; }
        public DateTime? ImageChanged { get; set; }

        public UInt64 ImageSize { get; set; }
        public UInt32 Width { get; set; }
        public UInt32 Height { get; set; }

        public String ImageType { get; set; }
    }
}
