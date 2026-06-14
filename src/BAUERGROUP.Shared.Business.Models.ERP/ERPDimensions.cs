using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Physical dimensions value object holding length, width and height as whole units.
    /// Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPDimensions : ERPObjectBase
    {
        /// <summary>Initialises all dimensions to zero.</summary>
        public ERPDimensions()
        {
            Length = Width = Height = 0;
        }

        /// <summary>Length component.</summary>
        public ushort Length { get; set; }
        /// <summary>Width component.</summary>
        public ushort Width { get; set; }
        /// <summary>Height component.</summary>
        public ushort Height { get; set; }
    }
}
