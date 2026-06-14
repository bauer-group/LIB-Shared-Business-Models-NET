using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockUnit : ERPCodeName
    {
        public ERPStockUnit() : 
            this(@"", @"")
        {

        }

        public ERPStockUnit(string sCode) :
            this(sCode, @"")
        {
            
        }

        public ERPStockUnit(string sCode, string sName)
        {
            Code = sCode;
            Name = sName;
            LoadingTools = new List<ERPStockLoadingTool>(0);
            UnitsInUnit = new List<ERPStockQuantity>(0);
            Type = ERPStockUnitType.StorageUnit;
        }

        public List<ERPStockLoadingTool> LoadingTools { get; set; }
        public List<ERPStockQuantity> UnitsInUnit { get; set; }
        public ERPStockUnitType Type { get; set; }
    }
}
