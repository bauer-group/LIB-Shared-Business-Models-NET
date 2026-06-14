# Enabling Nullable Reference Types — deferred changeover plan

**Status:** deferred as of **2.0.0 (2026-06-14)**.
`Shipping` and `ERP` are `<Nullable>disable</Nullable>`; the hand-written
packages (`base`, `CRM`, `DMS`) and the tests are already `enable`.

This document captures the complete analysis so the changeover can be executed
later without re-discovery. It is a turnkey plan, not a backlog stub.

## Why it was deferred

The 2.0.0 consolidation prioritized backward-compatibility and minimal churn on
the migrated legacy code. Enabling NRT here is **not** a bug fix and **not** a
behavior change — it is an annotation pass over the public model surface
(~170 reference properties). There are essentially no real null-safety *bugs*;
the legacy code already handles its optional fields correctly at runtime. The
task is to *declare* the nullability that already exists.

## What enabling it produces (measured, not estimated)

Experiment: flip both migrated projects to `<Nullable>enable</Nullable>` and
build all three TFMs (`net10.0;net8.0;netstandard2.0`).

- **Build still succeeds (0 errors)** because the migrated projects keep
  `TreatWarningsAsErrors=false` — the issues surface as **warnings**.
- **~1,078 nullable warnings** across the three TFMs (~360 per TFM):

  | Code | Count (×3 TFM) | Meaning |
  | --- | --- | --- |
  | **CS8625** | 546 | a `null` literal assigned to a non-nullable reference (`X = null;` in a ctor) |
  | **CS8618** | 510 | a non-nullable reference property is not guaranteed non-null when the ctor exits |
  | CS8603 | 18 | a method may `return null` from a non-nullable return type |
  | CS8602 | 4 | dereference of a possibly-null value |

- With the **strict bar** (`TreatWarningsAsErrors=true`, like the base package)
  those ~360/TFM become **errors** → the build fails until they are resolved.

## Root cause and the annotation rule

The legacy constructors assign `null` to reference properties (or leave them
unset), while NRT defaults every reference type to **non-nullable**. The
constructors are therefore a built-in nullability spec:

> - A property assigned `null` (or never assigned) in any constructor → annotate
>   it **nullable** (`String?`, `Byte[]?`, `Uri?`).
> - A property assigned `new …()` / a real value in **every** constructor →
>   leave it **non-nullable** (these already produce no warning).

### Worked example — `Shipping/CarrierDocument.cs`

```csharp
// BEFORE (Nullable disable)
public CarrierDocument(Byte[] oContent, ...) { Content = oContent; URI = null; }
public CarrierDocument(Uri oURI, ...)        { Content = null;     URI = oURI; }
public Byte[] Content { get; set; }   // CS8618 (a ctor leaves it null)
public Uri    URI     { get; set; }   // CS8618
//  URI = null / Content = null       -> CS8625

// AFTER (Nullable enable) — a CarrierDocument is EITHER content OR a URI,
// so both are genuinely nullable; the annotation just makes that honest:
public Byte[]? Content { get; set; }
public Uri?    URI     { get; set; }
```

All four warnings on this type disappear once the two properties are `?`.

## Step-by-step changeover (per package — pilot Shipping first)

1. Remove `<Nullable>disable</Nullable>` from the package's relaxation block
   (it inherits `enable` from `Directory.Build.props`).
2. Annotate reference properties with `?` per the rule above. **Keep the house
   conventions**: `String`/`Decimal`/`Boolean` BCL casing and Hungarian
   parameter/local names — this pass changes nullability only.
3. Resolve the handful of `CS8603` (return null, ~18) and `CS8602` (deref, ~4)
   sites individually — add `?` to the return type or a null-guard as fits.
4. Build + run the test suite green. Keep `TreatWarningsAsErrors=false` during
   the pass; once clean, optionally **restore `TreatWarningsAsErrors=true`** on
   that package to lock the bar in (drop it from the relaxation block).
5. **Verify PackageValidation** — see below — then ship.
6. Repeat for ERP (the bulk of the ~170 properties).

The pass is independent per package and can ship incrementally.

## Compatibility — this ships as a MINOR, not a breaking change

- **Binary / ABI: compatible.** NRT is metadata only; `string?` and `string`
  are the same `System.String` at runtime. Already-compiled consumers are
  unaffected.
- **PackageValidation baseline (2.0.0): not flagged.** The 2.0.0 assemblies are
  nullable-*oblivious*; ApiCompat treats oblivious → annotated as compatible, so
  no breaking-change error and no `CompatibilitySuppressions.xml` needed. No
  major bump — it releases as e.g. `2.1.0` (a `feat:`/`refactor:`).
- **Consumers with NRT enabled** gain an accurate null-safety contract and may
  see new *warnings* where they previously ignored possible nulls (errors only
  if that consumer uses `TreatWarningsAsErrors`).

## Effort

- **Shipping** — ~38 files; small, ideal pilot to validate the approach and the
  downstream warning impact.
- **ERP** — ~143 files; carries most of the ~170 property annotations.

Mechanical and low-risk (annotation, not logic). Budget per-package rather than
as one big-bang change.

## Reproduce the warning inventory

```bash
# enable, build, count
sed -i 's#<Nullable>disable</Nullable>#<Nullable>enable</Nullable>#' \
  src/BAUERGROUP.Shared.Business.Models.Shipping/*.csproj \
  src/BAUERGROUP.Shared.Business.Models.ERP/*.csproj
dotnet build BAUERGROUP.Shared.Business.Models.slnx -c Release --no-incremental -v normal > nrt.log 2>&1
grep -oE 'warning CS8[0-9]{3}' nrt.log | sort | uniq -c | sort -rn

# revert
sed -i 's#<Nullable>enable</Nullable>#<Nullable>disable</Nullable>#' \
  src/BAUERGROUP.Shared.Business.Models.Shipping/*.csproj \
  src/BAUERGROUP.Shared.Business.Models.ERP/*.csproj
```

## Related deferred hardening

- **ERP `System.Text.Json` round-trip gap** — `ERPText` / `ERPLanguage` (reached
  via `ERPCountry.DisplayNames`) have only parameterized constructors, so
  `Clone()`/deserialize throws on ERP graphs that contain them. Adding
  parameterless constructors or `[JsonConstructor]` is the fix. See
  [MIGRATION.md](MIGRATION.md).
