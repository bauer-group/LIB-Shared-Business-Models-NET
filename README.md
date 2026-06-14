# BAUER GROUP — Shared Business Models

[![Release & Publish](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/actions/workflows/dotnet-release.yml/badge.svg)](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/actions/workflows/dotnet-release.yml)
[![NuGet](https://img.shields.io/nuget/v/BAUERGROUP.Shared.Business.Models.svg?label=NuGet&logo=nuget)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models)
[![Downloads](https://img.shields.io/nuget/dt/BAUERGROUP.Shared.Business.Models.svg?label=downloads&logo=nuget)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models)
[![.NET](https://img.shields.io/badge/.NET-net10%20%7C%20net8%20%7C%20netstandard2.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/LICENSE)

Cross-platform **POCO domain models** for the BAUER GROUP Shared Business
ecosystem: a dependency-free base package plus a family of domain satellites,
all multi-targeted for **`net10.0` · `net8.0` · `netstandard2.0`**.

The `netstandard2.0` leg keeps the models consumable from .NET Framework 4.6.2+,
Unity, Xamarin and other legacy hosts; modern C# language features (`init`
accessors, `required` members) are backfilled there via
[PolySharp](https://github.com/Sergio0694/PolySharp).

## Packages

| Package | NuGet | Depends on |
| --- | --- | --- |
| [`BAUERGROUP.Shared.Business.Models`](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models) | [![NuGet](https://img.shields.io/nuget/v/BAUERGROUP.Shared.Business.Models.svg)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models) | **none** (base) |
| [`BAUERGROUP.Shared.Business.Models.Shipping`](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.Shipping) | [![NuGet](https://img.shields.io/nuget/v/BAUERGROUP.Shared.Business.Models.Shipping.svg)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.Shipping) | Core |
| [`BAUERGROUP.Shared.Business.Models.ERP`](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.ERP) | [![NuGet](https://img.shields.io/nuget/v/BAUERGROUP.Shared.Business.Models.ERP.svg)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.ERP) | Models · Shipping · Core |
| [`BAUERGROUP.Shared.Business.Models.CRM`](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.CRM) | [![NuGet](https://img.shields.io/nuget/v/BAUERGROUP.Shared.Business.Models.CRM.svg)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.CRM) | Models |
| [`BAUERGROUP.Shared.Business.Models.DMS`](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.DMS) | [![NuGet](https://img.shields.io/nuget/v/BAUERGROUP.Shared.Business.Models.DMS.svg)](https://www.nuget.org/packages/BAUERGROUP.Shared.Business.Models.DMS) | Models |

> The **base** package is strictly **0-dependency**. Domain satellites may layer
> on [`BAUERGROUP.Shared.Core`](https://www.nuget.org/packages/BAUERGROUP.Shared.Core)
> for shared primitives (e.g. `IndependentImage`).

## Install

```bash
dotnet add package BAUERGROUP.Shared.Business.Models
# domain satellites, as needed:
dotnet add package BAUERGROUP.Shared.Business.Models.Shipping
dotnet add package BAUERGROUP.Shared.Business.Models.ERP
```

## Quick start

```csharp
using BAUERGROUP.Shared.Business.Models;

public sealed class Customer : BusinessObject
{
    public Customer() { }                       // UID auto-generated
    public Customer(Guid gUID) : base(gUID) { } // re-hydrate with a known identity

    public required string Name { get; init; }
}

var c = new Customer { Name = "Contoso" };
// c.UID     -> a fresh Guid (init-only); pass an explicit one via the ctor or initializer
// c.Changed -> DateTime.UtcNow at construction, mutable on update
```

### Deep clone

Models are deep-cloned via the `BAUERGROUP.Shared.Core` JSON helper:

```csharp
using BAUERGROUP.Shared.Core.Extensions;

var copy = original.Clone();   // safe System.Text.Json deep copy
```

> Cloning/serialization requires the type to round-trip through `System.Text.Json`
> (a public parameterless constructor or `[JsonConstructor]`). A few legacy ERP
> value types don't yet — see the [migration guide](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/docs/MIGRATION.md).

## Documentation

- [Architecture](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/docs/ARCHITECTURE.md) — package family, dependency DAG, identity & cloning
- [Migration guide](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/docs/MIGRATION.md) — moving from the legacy `BAUERGROUP.Shared.*` packages
- [Build](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/docs/BUILD.md) — building, testing, packing
- [Versioning](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/docs/VERSIONING.md) — semantic-release & conventional commits
- [Nullable-enable plan](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/docs/NULLABLE-ENABLE.md) — the deferred NRT changeover for Shipping/ERP
- [Changelog](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/CHANGELOG.md)

## License

[MIT](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/blob/main/LICENSE) © BAUER GROUP
