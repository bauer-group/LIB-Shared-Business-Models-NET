using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Physical extents (length, width, height) of a parcel or packaging.
    /// </summary>
    public class ParcelDimensions
    {
        /// <summary>Initialises a new instance with all dimensions set to zero.</summary>
        public ParcelDimensions()
            : this(0, 0, 0)
        {

        }

        /// <summary>Initialises a new instance with the given length, width and height.</summary>
        /// <param name="iLength">Length to assign.</param>
        /// <param name="iWidth">Width to assign.</param>
        /// <param name="iHeight">Height to assign.</param>
        public ParcelDimensions(UInt16 iLength, UInt16 iWidth, UInt16 iHeight)
        {
            Length = iLength;
            Width = iWidth;
            Height = iHeight;
        }

        /// <summary>Length of the parcel.</summary>
        public UInt16 Length { get; set; }
        /// <summary>Width of the parcel.</summary>
        public UInt16 Width { get; set; }
        /// <summary>Height of the parcel.</summary>
        public UInt16 Height { get; set; }
    }
}
