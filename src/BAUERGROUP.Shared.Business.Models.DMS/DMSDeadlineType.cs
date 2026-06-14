namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Kind of deadline / follow-up (Fristsache) on a document. <see cref="Resubmission"/> models the
/// classic Wiedervorlage.
/// </summary>
public enum DMSDeadlineType
{
    /// <summary>Type not set.</summary>
    Unspecified = 0,
    /// <summary>Resubmission / bring-forward (Wiedervorlage).</summary>
    Resubmission = 1,
    /// <summary>A hard deadline (Frist).</summary>
    Deadline = 2,
    Reminder = 3,
    Review = 4,
    /// <summary>Renewal date (e.g. a contract).</summary>
    Renewal = 5,
    /// <summary>Expiry date.</summary>
    Expiry = 6,
    /// <summary>A deadline that does not fit the predefined set.</summary>
    Other = 9999
}
