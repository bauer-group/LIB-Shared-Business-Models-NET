using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.ERP.Configuration;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPWeight : ERPObjectBase
    {
        public ERPWeight()
        {
            NetWeight = 0m;
            GrossWeight = 0m;
        }

        public Decimal NetWeight { get; set; }
        public Decimal GrossWeight { get; set; }

        public Decimal Tare
        {
            get
            {
                return GrossWeight - NetWeight;
            }
        }

        public Decimal Weight
        {
            set
            {                
                NetWeight = value;
                GrossWeight = value;                
            }
        }

        public String Unit
        {
            get
            {
                return ERPUnits.Weight;
            }
        }
    }
}
