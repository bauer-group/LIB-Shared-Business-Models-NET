using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.ERP.Configuration;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Weight value object tracking net and gross weight in the configured <see cref="Unit"/>.
    /// Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPWeight : ERPObjectBase
    {
        /// <summary>Initialises net and gross weight to zero.</summary>
        public ERPWeight()
        {
            NetWeight = 0m;
            GrossWeight = 0m;
        }

        /// <summary>Net weight in the configured <see cref="Unit"/>.</summary>
        public Decimal NetWeight { get; set; }
        /// <summary>Gross weight in the configured <see cref="Unit"/>.</summary>
        public Decimal GrossWeight { get; set; }

        /// <summary>Tare weight: gross minus net weight.</summary>
        public Decimal Tare
        {
            get
            {
                return GrossWeight - NetWeight;
            }
        }

        /// <summary>Write-only shortcut that sets both net and gross weight to the same value.</summary>
        public Decimal Weight
        {
            set
            {
                NetWeight = value;
                GrossWeight = value;
            }
        }

        /// <summary>Weight unit of measure, taken from <c>ERPUnits.Weight</c>.</summary>
        public String Unit
        {
            get
            {
                return ERPUnits.Weight;
            }
        }
    }
}
