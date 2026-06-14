namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Kind of folder node in the physical/logical filing tree.</summary>
public enum DMSFolderType
{
    /// <summary>Kind not set.</summary>
    Unspecified = 0,
    Cabinet = 1,
    Drawer = 2,
    Folder = 3,
    Register = 4,
    /// <summary>A node kind that does not fit the predefined set.</summary>
    Other = 9999
}
