namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Marketing / sales lifecycle stage of an account or contact.</summary>
public enum CRMLifecycleStage
{
    /// <summary>Stage not set.</summary>
    Unspecified = 0,
    Subscriber = 1,
    Lead = 2,
    MarketingQualifiedLead = 3,
    SalesQualifiedLead = 4,
    Opportunity = 5,
    Customer = 6,
    Evangelist = 7,
    Churned = 8,
    /// <summary>A stage that does not fit the predefined lifecycle.</summary>
    Other = 9999
}
