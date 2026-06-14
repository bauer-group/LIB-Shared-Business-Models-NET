# BAUER GROUP — Shared Business Models

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

Dependency-free **POCO domain models** for the BAUER GROUP Shared Business
ecosystem. This package is the foundation every other Business library builds
on — it ships marker interfaces and abstract base classes with **zero runtime
NuGet dependencies** beyond the .NET BCL.

## Target frameworks

`net10.0` · `net8.0` · `netstandard2.0`

The `netstandard2.0` leg keeps the models consumable from .NET Framework 4.6.2+,
Unity, Xamarin and other legacy hosts. Modern C# language features (`init`
accessors, `required` members) are backfilled there via
[PolySharp](https://github.com/Sergio0694/PolySharp).

## What's in the base package

| Type | Kind | Purpose |
| --- | --- | --- |
| `IBusiness` | interface | Marker for any business type in the framework. |
| `IBusinessObject` | interface | `IBusiness` + stable `UID` identity and a `Changed` timestamp. |
| `Business` | abstract class | Base for business types that need no identity. |
| `BusinessObject` | abstract class | Base with auto-generated `UID` (`Guid`) and UTC `Changed` stamp. |

```csharp
using BAUERGROUP.Shared.Business.Models;

public sealed class Customer : BusinessObject
{
    public required string Name { get; init; }
}

var c = new Customer { Name = "Contoso" };
// c.UID     -> a fresh Guid, init-only
// c.Changed -> DateTime.UtcNow at construction, mutable on update
```

## Package family

This repository hosts the base package plus a set of domain-specific model
satellites that build on it:

| Package | Depends on |
| --- | --- |
| `BAUERGROUP.Shared.Business.Models` | *(base — this package)* |
| `BAUERGROUP.Shared.Business.Models.Shipping` | Models |
| `BAUERGROUP.Shared.Business.Models.ERP` | Models + Shipping |
| `BAUERGROUP.Shared.Business.Models.CRM` | Models |
| `BAUERGROUP.Shared.Business.Models.DMS` | Models |

## Building

```bash
dotnet build BAUERGROUP.Shared.Business.Models.slnx -c Release
dotnet pack  BAUERGROUP.Shared.Business.Models.slnx -c Release
```

Build output (bin/obj/packages) is centralized under `artifacts/`. Releases and
NuGet publishing are automated via conventional commits and semantic-release —
see [`.github/workflows/dotnet-release.yml`](.github/workflows/dotnet-release.yml).

## License

[MIT](LICENSE) © BAUER GROUP
