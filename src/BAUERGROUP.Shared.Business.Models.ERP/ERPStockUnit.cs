using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A stock-keeping unit instance. Extends <see cref="ERPCodeName"/>, carrying a code/name
    /// identity, and adds its loading tools, nested unit quantities and unit classification.
    /// </summary>
    public class ERPStockUnit : ERPCodeName
    {
        /// <summary>Initialises a new instance with an empty code and name.</summary>
        public ERPStockUnit() :
            this(@"", @"")
        {

        }

        /// <summary>Initialises a new instance with the given code and an empty name.</summary>
        /// <param name="sCode">Stock unit code.</param>
        public ERPStockUnit(string sCode) :
            this(sCode, @"")
        {

        }

        /// <summary>Initialises a new instance with the given code and name; defaults the type to <see cref="ERPStockUnitType.StorageUnit"/>.</summary>
        /// <param name="sCode">Stock unit code.</param>
        /// <param name="sName">Display name of the stock unit.</param>
        public ERPStockUnit(string sCode, string sName)
        {
            Code = sCode;
            Name = sName;
            LoadingTools = new List<ERPStockLoadingTool>(0);
            UnitsInUnit = new List<ERPStockQuantity>(0);
            Type = ERPStockUnitType.StorageUnit;
        }

        /// <summary>Loading tools (e.g. pallets, carriers) associated with this unit.</summary>
        public List<ERPStockLoadingTool> LoadingTools { get; set; }
        /// <summary>Quantities of sub-units contained within this unit.</summary>
        public List<ERPStockQuantity> UnitsInUnit { get; set; }
        /// <summary>Classification of this stock unit (storage, sale or delivery).</summary>
        public ERPStockUnitType Type { get; set; }
    }
}
