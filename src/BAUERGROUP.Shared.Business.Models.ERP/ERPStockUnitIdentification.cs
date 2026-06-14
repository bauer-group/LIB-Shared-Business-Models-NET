using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Identifies stock units (e.g. via SSCC / license plate) by mapping each
    /// <see cref="ERPStockUnit"/> to its list of <see cref="ERPProductLabeling"/> entries.
    /// </summary>
    public class ERPStockUnitIdentification : Dictionary<ERPStockUnit, List<ERPProductLabeling>>
    {
        /// <summary>Initialises a new, empty identification map.</summary>
        public ERPStockUnitIdentification()
        {

        }

        /// <summary>Initialises a new instance with a single unit-to-labeling entry.</summary>
        /// <param name="sUnitCode">Stock unit code; wrapped in a new <see cref="ERPStockUnit"/>.</param>
        /// <param name="sCode">Labeling code; wrapped in a new <see cref="ERPProductLabeling"/>.</param>
        public ERPStockUnitIdentification(string sUnitCode, string sCode)
        {
            Add(new ERPStockUnit(sUnitCode), new List<ERPProductLabeling>(1) { { new ERPProductLabeling(sCode) } });
        }
    }
}
