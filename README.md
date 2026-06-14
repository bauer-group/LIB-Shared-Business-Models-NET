# BAUER GROUP — Shared Business Models

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

Cross-platform **POCO domain models** for the BAUER GROUP Shared Business
ecosystem. A dependency-free base package plus a family of domain satellites,
all multi-targeted for **`net10.0` · `net8.0` · `netstandard2.0`**.

The `netstandard2.0` leg keeps the models consumable from .NET Framework 4.6.2+,
Unity, Xamarin and other legacy hosts; modern C# language features (`init`
accessors, `required` members) are backfilled there via
[PolySharp](https://github.com/Sergio0694/PolySharp).

## Packages

| Package | Purpose | Dependencies |
| --- | --- | --- |
| `BAUERGROUP.Shared.Business.Models` | Base: `IBusiness` / `IBusinessObject`, `Business` / `BusinessObject` (stable `UID` + `Changed`) | **none** |
| `BAUERGROUP.Shared.Business.Models.Shipping` | Parcels, addresses, customs, carriers, shipping documents | Core |
| `BAUERGROUP.Shared.Business.Models.ERP` | Business associates, documents, products, prices, taxes, stock | Models · Shipping · Core |
| `BAUERGROUP.Shared.Business.Models.CRM` | CRM domain models *(greenfield)* | Models |
| `BAUERGROUP.Shared.Business.Models.DMS` | Document-management models *(greenfield)* | Models |

> The **base** package is strictly **0-dependency**. Domain satellites may layer
> on [`BAUERGROUP.Shared.Core`](https://github.com/bauer-group/LIB-Shared-Plattform-NET)
> for shared primitives (e.g. `IndependentImage`).

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
> value types don't yet — see [docs/MIGRATION.md](docs/MIGRATION.md).

## Documentation

- [Architecture](docs/ARCHITECTURE.md) — package family, dependency DAG, identity & cloning
- [Migration guide](docs/MIGRATION.md) — moving from the legacy `BAUERGROUP.Shared.*` packages
- [Build](docs/BUILD.md) — building, testing, packing
- [Versioning](docs/VERSIONING.md) — semantic-release & conventional commits

## License

[MIT](LICENSE) © BAUER GROUP
