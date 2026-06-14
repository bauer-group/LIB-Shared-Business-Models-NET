using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDimensions : ERPObjectBase
    {
        public ERPDimensions()
        {
            Length = Width = Height = 0;
        }

        public ushort Length { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
    }
}
