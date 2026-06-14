using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Licensing and attribution metadata for an <see cref="ERPPicture"/>, including who licensed the
    /// image and the optional validity window of the license.
    /// </summary>
    public class ERPPictureLicense
    {
        /// <summary>Initialises a new instance defaulting to <see cref="ERPPictureLicensor.OwnCreation"/> with unbounded validity.</summary>
        public ERPPictureLicense()
        {
            Licensor = ERPPictureLicensor.OwnCreation;
            LicensorIdentity = null;
            // ValidFrom/ValidTo null => unbounded validity (was Itenso TimeRange.Anytime).
        }

        /// <summary>Category of party that licensed the image.</summary>
        public ERPPictureLicensor Licensor { get; set; }
        /// <summary>Concrete business associate that granted the license (<c>null</c> if not identified).</summary>
        public ERPBusinessAssociate LicensorIdentity { get; set; }

        /// <summary>Start of the license validity window (<c>null</c> = no lower bound).</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>End of the license validity window (<c>null</c> = no upper bound).</summary>
        public DateTime? ValidTo { get; set; }
    }
}
