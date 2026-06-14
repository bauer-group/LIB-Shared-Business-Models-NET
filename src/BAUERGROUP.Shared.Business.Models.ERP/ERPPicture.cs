using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An image asset tracked in the ERP. Extends <see cref="ERPObjectBase"/> and bundles the
    /// image location together with its technical <see cref="Details"/> and <see cref="License"/> metadata.
    /// </summary>
    public class ERPPicture : ERPObjectBase
    {
        /// <summary>Initialises a new picture with neutral defaults and empty detail/license sub-objects.</summary>
        public ERPPicture()
        {
            Name = null;
            Description = null;

            IsActive = true;

            Url = null;

            Details = new ERPPictureDetails();

            License = new ERPPictureLicense();
        }

        /// <summary>Display name of the picture.</summary>
        public String Name { get; set; }
        /// <summary>Free-text description of the picture.</summary>
        public String Description { get; set; }

        /// <summary>Whether the picture is currently active and may be used.</summary>
        public Boolean IsActive { get; set; }

        /// <summary>Location of the image (URL or path).</summary>
        public String Url { get; set; }

        /// <summary>Technical image metadata (size, dimensions, MIME type, timestamps).</summary>
        public ERPPictureDetails Details { get; set; }

        /// <summary>Licensing and attribution information for the image.</summary>
        public ERPPictureLicense License { get; set; }
    }
}
