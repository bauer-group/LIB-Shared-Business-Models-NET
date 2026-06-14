namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Which domain the target of a document link lives in. Lets a DMS document reference a CRM contact
/// or an ERP invoice purely by id, without the DMS package depending on those systems at the type
/// level.
/// </summary>
public enum DMSLinkDomain
{
    /// <summary>Another DMS object (the default).</summary>
    DMS = 0,
    /// <summary>A CRM object (account, contact, opportunity, case …).</summary>
    CRM = 1,
    /// <summary>An ERP object (document, business associate, product …).</summary>
    ERP = 2,
    /// <summary>An object in an external system.</summary>
    External = 9999
}
