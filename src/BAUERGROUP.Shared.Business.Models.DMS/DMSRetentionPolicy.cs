using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A reusable retention rule. Extends <see cref="ERPCodeName"/> (Code + Name) and states the
/// records category, the retention period in years, the legal basis and the disposition action.
/// Policies are data-driven, e.g. "TaxRelevant / 10 years / § 147 AO / Review" or
/// "CommercialLetter / 6 years / § 257 HGB / Review".
/// </summary>
public class DMSRetentionPolicy : ERPCodeName
{
    /// <summary>Initialises a new policy with neutral defaults.</summary>
    public DMSRetentionPolicy()
    {
        Category = DMSRetentionCategory.Unspecified;
        LegalBasis = DMSRetentionLegalBasis.Unspecified;
        DispositionAction = DMSDispositionAction.Review;
        RetentionYears = 0;
        Description = @"";
        IsImmutable = false;
        IsActive = true;
    }

    /// <summary>Records category the policy applies to.</summary>
    public DMSRetentionCategory Category { get; set; }

    /// <summary>Statutory basis for the rule.</summary>
    public DMSRetentionLegalBasis LegalBasis { get; set; }

    /// <summary>What to do once the period elapses.</summary>
    public DMSDispositionAction DispositionAction { get; set; }

    /// <summary>Retention period in years.</summary>
    public Int32 RetentionYears { get; set; }

    /// <summary>Plain-language description / legal note.</summary>
    public String Description { get; set; }

    /// <summary>Whether documents are write-protected (WORM) for the duration of the period.</summary>
    public Boolean IsImmutable { get; set; }

    /// <summary>Whether the policy is currently assignable.</summary>
    public Boolean IsActive { get; set; }
}
