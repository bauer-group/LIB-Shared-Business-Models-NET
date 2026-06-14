namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Sales-forecast bucket an opportunity contributes to.</summary>
public enum CRMForecastCategory
{
    /// <summary>Not categorised.</summary>
    Unspecified = 0,
    Omitted = 1,
    Pipeline = 2,
    BestCase = 3,
    Commit = 4,
    Closed = 5
}
