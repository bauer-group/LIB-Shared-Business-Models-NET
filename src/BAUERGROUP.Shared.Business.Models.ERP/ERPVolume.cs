using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.ERP.Configuration;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Volume value object tracking net and gross volume in the configured <see cref="Unit"/>.
    /// Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPVolume : ERPObjectBase
    {
        /// <summary>Initialises net and gross volume to zero.</summary>
        public ERPVolume()
        {
            NetVolume = 0m;
            GrossVolume = 0m;
        }

        /// <summary>Net volume in the configured <see cref="Unit"/>.</summary>
        public Decimal NetVolume { get; set; }
        /// <summary>Gross volume in the configured <see cref="Unit"/>.</summary>
        public Decimal GrossVolume { get; set; }

        /// <summary>Gross minus net volume.</summary>
        public Decimal Difference
        {
            get
            {
                return GrossVolume - NetVolume;
            }
        }

        /// <summary>Write-only shortcut that sets both net and gross volume to the same value.</summary>
        public Decimal Volume
        {
            set
            {
                NetVolume = value;
                GrossVolume = value;
            }
        }

        /// <summary>Volume unit of measure, taken from <c>ERPUnits.Volume</c>.</summary>
        public String Unit
        {
            get
            {
                return ERPUnits.Volume;
            }
        }
    }
}
