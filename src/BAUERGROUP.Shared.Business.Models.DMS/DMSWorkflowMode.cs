namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>How the steps of a workflow are evaluated.</summary>
public enum DMSWorkflowMode
{
    /// <summary>Steps run one after another in order.</summary>
    Sequential = 0,
    /// <summary>All steps are active at once and must all decide.</summary>
    Parallel = 1,
    /// <summary>Any single approval among the steps is sufficient (quorum of one).</summary>
    AnyOne = 2
}
