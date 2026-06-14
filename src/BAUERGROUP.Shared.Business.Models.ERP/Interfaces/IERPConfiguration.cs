using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Interfaces
{
    /// <summary>
    /// Configuration contract for an ERP service. Marker interface carried by
    /// <see cref="IERPAPI.Configuration"/>; implementations supply the connection and
    /// behaviour settings required by a concrete ERP backend.
    /// </summary>
    public interface IERPConfiguration
    {
        
    }
}
