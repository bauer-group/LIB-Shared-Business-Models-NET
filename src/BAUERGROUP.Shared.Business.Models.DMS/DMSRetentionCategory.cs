namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Records-management category of a document, driving which statutory retention rule applies
/// (e.g. German GoBD: tax-relevant records and accounting books 10 years, commercial letters and
/// business emails 6 years).
/// </summary>
public enum DMSRetentionCategory
{
    /// <summary>Category not assigned.</summary>
    Unspecified = 0,
    /// <summary>Tax-relevant records / accounting books (steuerrelevante Unterlagen).</summary>
    TaxRelevant = 1,
    /// <summary>Commercial / business letters (Handelsbriefe).</summary>
    CommercialLetter = 2,
    /// <summary>Accounting vouchers and records (Buchungsbelege).</summary>
    AccountingRecord = 3,
    /// <summary>Business emails treated as commercial correspondence.</summary>
    Email = 4,
    /// <summary>Contracts and agreements.</summary>
    Contract = 5,
    /// <summary>Personnel / HR records.</summary>
    Personnel = 6,
    /// <summary>Health, safety and environmental records.</summary>
    HealthAndSafety = 7,
    /// <summary>A category that does not fit the predefined set.</summary>
    Other = 9999
}
