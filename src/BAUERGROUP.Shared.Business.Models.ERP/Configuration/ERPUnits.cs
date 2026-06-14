using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Configuration
{
    /// <summary>
    /// Unit-of-measure configuration for the ERP model. Defines the canonical units in which
    /// ERP weight and volume values are expressed.
    /// </summary>
    public static class ERPUnits
    {
        /// <summary>Unit of measure for weight values (<c>kg</c>).</summary>
        public static string Weight { get { return "kg"; } }
        /// <summary>Unit of measure for volume values (<c>cbm</c>, cubic metres).</summary>
        public static string Volume { get { return "cbm"; } }
    }
}
