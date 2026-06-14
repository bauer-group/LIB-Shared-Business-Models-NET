using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ParcelDimensions
    {
        public ParcelDimensions()
            : this(0, 0, 0)
        {
            
        }

        public ParcelDimensions(UInt16 iLength, UInt16 iWidth, UInt16 iHeight)
        {
            Length = iLength;
            Width = iWidth;
            Height = iHeight;
        }

        public UInt16 Length { get; set; }
        public UInt16 Width { get; set; }
        public UInt16 Height { get; set; }
    }
}
