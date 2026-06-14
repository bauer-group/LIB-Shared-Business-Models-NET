using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An image linked to a product, carrying the usage roles it is licensed/intended for.
    /// Extends <see cref="ERPPicture"/>.
    /// </summary>
    public class ERPProductPicture : ERPPicture
    {
        /// <summary>Initialises a new instance allowing <see cref="ERPProductPictureUsage.Preview"/>, <see cref="ERPProductPictureUsage.Print"/> and <see cref="ERPProductPictureUsage.Online"/> usage.</summary>
        public ERPProductPicture()
        {
            Useage = ERPProductPictureUsage.Preview | ERPProductPictureUsage.Print | ERPProductPictureUsage.Online;
        }

        /// <summary>Usage roles for which this picture may be used (bit flags).</summary>
        public ERPProductPictureUsage Useage { get; set; }
    }
}
