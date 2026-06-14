namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Kind of interaction recorded as an activity.</summary>
public enum CRMActivityType
{
    /// <summary>Type not set.</summary>
    Unspecified = 0,
    Call = 1,
    Meeting = 2,
    Email = 3,
    Task = 4,
    Note = 5,
    Letter = 6,
    Appointment = 7,
    /// <summary>An interaction that does not fit the predefined types.</summary>
    Other = 9999
}
