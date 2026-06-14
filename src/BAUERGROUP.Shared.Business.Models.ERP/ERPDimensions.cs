using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
