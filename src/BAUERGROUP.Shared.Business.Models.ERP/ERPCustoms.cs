using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPCustoms: ERPObjectBase
    {
        public ERPCustoms()
        {
            TariffNumber = @"";
            Value = 0m;
            Currency = ERPCurrency.EUR;
            Text = new List<ERPProductText>(0);            
        }

        public String TariffNumber { get; set; }
        public Decimal Value { get; set; }
        public ERPCurrency Currency { get; set; }
        public List<ERPProductText> Text { get; set; }
    }
}
