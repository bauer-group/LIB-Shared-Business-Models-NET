using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A configurable stage in a sales pipeline. Extends <see cref="ERPCodeName"/> (Code + Name) and
/// adds ordering, the default win probability and the terminal-stage flags. Pipelines are
/// data-driven: an application defines the ordered set of stages it needs.
/// </summary>
public class CRMPipelineStage : ERPCodeName
{
    /// <summary>Initialises a new stage with neutral defaults.</summary>
    public CRMPipelineStage()
    {
        Order = 0;
        Probability = 0m;
        IsWon = false;
        IsLost = false;
        IsActive = true;
    }

    /// <summary>Sort order of the stage within its pipeline (ascending).</summary>
    public Int32 Order { get; set; }

    /// <summary>Default win probability for opportunities at this stage (0–100).</summary>
    public Decimal Probability { get; set; }

    /// <summary>Marks the terminal "won" stage.</summary>
    public Boolean IsWon { get; set; }

    /// <summary>Marks a terminal "lost" stage.</summary>
    public Boolean IsLost { get; set; }

    /// <summary>Whether the stage is currently selectable.</summary>
    public Boolean IsActive { get; set; }
}
