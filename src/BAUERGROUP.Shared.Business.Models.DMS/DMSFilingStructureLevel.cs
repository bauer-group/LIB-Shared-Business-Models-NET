using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// One level of a virtual path structure. Each level is derived from an index field (e.g. the
/// document year, the customer name), optionally reformatted by <see cref="FormatPattern"/>, to
/// build a segment of the virtual path.
/// </summary>
public class DMSFilingStructureLevel : DMSObjectBase
{
    /// <summary>Initialises a new level with neutral defaults.</summary>
    public DMSFilingStructureLevel()
    {
        Order = 0;
        Caption = @"";
        SourceIndexFieldCode = @"";
        FormatPattern = @"";
    }

    /// <summary>Depth of this level within the structure (ascending).</summary>
    public Int32 Order { get; set; }

    /// <summary>Display caption for the level.</summary>
    public String Caption { get; set; }

    /// <summary>Code of the index field whose value drives this level's segment.</summary>
    public String SourceIndexFieldCode { get; set; }

    /// <summary>Optional format pattern applied to the source value (e.g. <c>yyyy</c> for a date).</summary>
    public String FormatPattern { get; set; }
}
