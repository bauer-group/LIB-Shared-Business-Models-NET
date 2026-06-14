using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// File format of a <see cref="CarrierDocument"/>.
    /// </summary>
    public enum CarrierDocumentFormat
    {
        /// <summary>Unknown or unspecified format.</summary>
        Other = 0,

        PDF = 1,

        BMP = 10,
        PNG = 11,
        TIFF = 12,

        /// <summary>Zebra Programming Language — raw thermal label-printer instructions.</summary>
        ZPL = 20
    }
}
