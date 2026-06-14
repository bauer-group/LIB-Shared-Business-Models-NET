namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Primary industry sector classification for an account.</summary>
public enum CRMIndustry
{
    /// <summary>Industry not classified.</summary>
    Unspecified = 0,
    Agriculture = 1,
    Automotive = 2,
    Banking = 3,
    Chemicals = 4,
    Construction = 5,
    Consulting = 6,
    Education = 7,
    Energy = 8,
    Engineering = 9,
    Finance = 10,
    FoodAndBeverage = 11,
    Government = 12,
    Healthcare = 13,
    Hospitality = 14,
    Insurance = 15,
    Legal = 16,
    Logistics = 17,
    Manufacturing = 18,
    Media = 19,
    Mining = 20,
    NonProfit = 21,
    Pharmaceuticals = 22,
    RealEstate = 23,
    Retail = 24,
    Technology = 25,
    Telecommunications = 26,
    Transportation = 27,
    Utilities = 28,
    Wholesale = 29,
    /// <summary>An industry that does not fit the predefined sectors.</summary>
    Other = 9999
}
