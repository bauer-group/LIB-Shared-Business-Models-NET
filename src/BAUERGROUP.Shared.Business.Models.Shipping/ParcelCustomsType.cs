using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public enum ParcelCustomsType
    {
        CommercialGoods = 0,
        
        ReturnOfGoods = 10,
        
        CommercialSample = 50,

        Present = 100,

        Document = 500,

        Other = 1000
    }
}