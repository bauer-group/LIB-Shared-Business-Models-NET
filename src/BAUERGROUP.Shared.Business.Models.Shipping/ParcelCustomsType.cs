using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Customs declaration category describing the nature of a parcel's contents.
    /// </summary>
    public enum ParcelCustomsType
    {
        CommercialGoods = 0,

        ReturnOfGoods = 10,

        CommercialSample = 50,

        Present = 100,

        Document = 500,

        /// <summary>A content type that does not fit the predefined categories.</summary>
        Other = 1000
    }
}