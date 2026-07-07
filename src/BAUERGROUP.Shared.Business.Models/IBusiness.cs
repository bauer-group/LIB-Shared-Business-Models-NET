using System;

namespace BAUERGROUP.Shared.Business.Models;

/// <summary>
/// Marker interface for all business types in the BAUER GROUP Shared Business framework.
/// </summary>
/// <remarks>
/// Implementations participate in the framework's plugin system, event bus, and
/// serialization conventions. Use <see cref="IBusinessObject"/> when a stable
/// identity and change timestamp are required.
/// </remarks>
public interface IBusiness
{
    
}
