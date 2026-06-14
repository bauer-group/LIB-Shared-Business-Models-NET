using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.ERP.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPVolume : ERPObjectBase
    {
        public ERPVolume()
        {
            NetVolume = 0m;
            GrossVolume = 0m;
        }

        public Decimal NetVolume { get; set; }
        public Decimal GrossVolume { get; set; }

        public Decimal Difference
        {
            get
            {
                return GrossVolume - NetVolume;
            }
        }

        public Decimal Volume
        {
            set
            {
                NetVolume = value;
                GrossVolume = value;
            }
        }

        public String Unit
        {
            get
            {
                return ERPUnits.Volume;
            }
        }
    }
}
