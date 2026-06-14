using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases.Interfaces.Bases
{
    public interface IERPObjectBase : IBusinessObject, IBusiness
    {        
        Guid ClientUID { get; set; }        
    }
}