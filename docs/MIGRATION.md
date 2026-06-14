# Migration guide

This repository consolidates several standalone legacy component libraries into
one POCO model family. The models were **rebased** from the old
`BAUERGROUP.Shared.Toolbox` foundation onto `BAUERGROUP.Shared.Core` — a
breaking change reflected by the **2.0.0** major release.

## Package & namespace mapping

| Legacy package / namespace | New package / namespace |
| --- | --- |
| `BAUERGROUP.Shared.Shipping` | `BAUERGROUP.Shared.Business.Models.Shipping` |
| `BAUERGROUP.Shared.ERP` | `BAUERGROUP.Shared.Business.Models.ERP` |
| `BAUERGROUP.Shared.DMS` *(had no model types)* | `BAUERGROUP.Shared.Business.Models.DMS` *(greenfield)* |
| *(none)* | `BAUERGROUP.Shared.Business.Models.CRM` *(greenfield)* |

The namespace root changes accordingly, e.g.
`BAUERGROUP.Shared.ERP.ERPAddress` → `BAUERGROUP.Shared.Business.Models.ERP.ERPAddress`.

## Breaking changes

1. **Base rebased: Toolbox → Core.** Types that referenced the old
   `BAUERGROUP.Shared.Toolbox.Portable.*` now use `BAUERGROUP.Shared.Core.*`:
   - `Toolbox.Portable.Images.IndependentImage` → `BAUERGROUP.Shared.Core.Images.IndependentImage`
     (`ShippingImage.Picture`).
   - `Toolbox.Portable.Extensions` helpers (e.g. `TrimPublicStringProperties`) →
     `BAUERGROUP.Shared.Core.Extensions`.
2. **ERP validity periods are now BCL.** `Itenso.TimePeriod.TimeRange Validity`
   on `ERPPictureLicense` and `ERPProductPrices` became two nullable BCL
   properties — `DateTime? ValidFrom` / `DateTime? ValidTo` (both `null` =
   unbounded, the former `TimeRange.Anytime`). The `Itenso.TimePeriod`
   dependency is gone.
3. **Namespaces changed** for every migrated type (see table above). Update
   `using` directives accordingly.
4. **Target frameworks**: all packages now multi-target `net10.0;net8.0;netstandard2.0`.

## What is *not* in this repository

- **IoT** — `BAUERGROUP.Shared.IoT` is intentionally **not** migrated here.
- **Connectors** — `*.Connectors` projects (Shipping/ERP integrations) are a
  separate, independent migration; they carry external dependencies and are not
  POCO models.
- **ERP extension helpers** were folded **into** the ERP package (there is no
  separate `*.Extensions` package); they resolve their helpers from
  `BAUERGROUP.Shared.Core.Extensions`.

## Cloning / serialization constraint

Deep clone and JSON serialization round-trip through `System.Text.Json`, which
needs a public parameterless constructor (or `[JsonConstructor]`) on every type
in the graph. A few legacy ERP value types — notably `ERPText` and
`ERPLanguage` (reached via `ERPCountry.DisplayNames`) — expose only
parameterized constructors and therefore **cannot be deserialized** today; an
ERP graph that contains them will throw on `Clone()`/`Deserialize`.

This is a known limitation carried over from the legacy code. Hardening
(adding parameterless constructors or `[JsonConstructor]`) is a follow-up task
and does not block the model surface itself.

## Identity construction

`BusinessObject`-derived entities now expose an explicit-identity constructor in
addition to the init-only `UID`:

```csharp
new ERPProductPrices()                    // UID auto-generated
new ERPProductPrices { UID = knownId }    // re-hydrate (object initializer)
new ERPObjectBase(knownId)                // re-hydrate (constructor)
```
