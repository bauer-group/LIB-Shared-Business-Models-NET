using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Technical metadata describing the underlying image file of an <see cref="ERPPicture"/>.
    /// </summary>
    public class ERPPictureDetails
    {
        /// <summary>Initialises a new instance with zeroed dimensions and a generic <c>application/octet-stream</c> type.</summary>
        public ERPPictureDetails()
        {
            ImageCreated = null;
            ImageChanged = null;

            ImageSize = 0;
            Width = 0;
            Height = 0;

            ImageType = @"application/octet-stream";
        }

        /// <summary>Creation timestamp of the image (<c>null</c> if unknown).</summary>
        public DateTime? ImageCreated { get; set; }
        /// <summary>Last-modified timestamp of the image (<c>null</c> if unknown).</summary>
        public DateTime? ImageChanged { get; set; }

        /// <summary>File size of the image in bytes.</summary>
        public UInt64 ImageSize { get; set; }
        /// <summary>Image width in pixels.</summary>
        public UInt32 Width { get; set; }
        /// <summary>Image height in pixels.</summary>
        public UInt32 Height { get; set; }

        /// <summary>MIME type of the image (defaults to <c>application/octet-stream</c>).</summary>
        public String ImageType { get; set; }
    }
}
