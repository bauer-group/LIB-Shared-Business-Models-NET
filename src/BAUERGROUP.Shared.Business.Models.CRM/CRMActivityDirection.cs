namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Direction of a communication activity relative to the organization.</summary>
public enum CRMActivityDirection
{
    /// <summary>Not applicable / not set (e.g. an internal task or note).</summary>
    Unspecified = 0,
    Inbound = 1,
    Outbound = 2
}
