# Build

## Prerequisites

- .NET SDK **10.0.100+** (pinned via [`global.json`](../global.json),
  `rollForward: latestMinor`). The SDK builds the `net8.0` and `netstandard2.0`
  legs too — no separate runtimes required.

## Common commands

```bash
# restore + build all packages (all target frameworks)
dotnet build BAUERGROUP.Shared.Business.Models.slnx -c Release

# run the test suite (unit + integration)
dotnet test BAUERGROUP.Shared.Business.Models.slnx -c Release

# produce NuGet packages (+ symbol packages) into artifacts/packages/
dotnet pack BAUERGROUP.Shared.Business.Models.slnx -c Release
```

## Layout

| Path | Contents |
| --- | --- |
| `src/` | the five model packages |
| `tests/` | `*.UnitTests` (domain + NetArchTest architecture) and `*.IntegrationTests` (serialization) |
| `artifacts/` | centralized build output — `bin/`, `obj/`, `packages/` (git-ignored) |
| `build/` | the strong-name signing key location (key itself is never committed) |
| `docs/` | this documentation |

## Repo-wide conventions

- **Central Package Management** — all package versions live in
  [`Directory.Packages.props`](../Directory.Packages.props); project files
  reference packages without a version. Transitive pinning is on.
- **Shared MSBuild defaults** — [`Directory.Build.props`](../Directory.Build.props)
  governs identity, multi-targeting, analyzers, SourceLink, signing and
  packaging for every project.
- **Package validation** — `EnablePackageValidation` checks that the
  `netstandard2.0`/`net8`/`net10` legs of each package expose a consistent
  public API surface.
- **Analyzers** — .NET analyzers, BannedApiAnalyzers (`BannedSymbols.txt`) and
  Roslynator run repo-wide. Migrated legacy projects relax the strictness (see
  [ARCHITECTURE.md](ARCHITECTURE.md)); hand-written packages keep it.

## Assembly signing

Strong-name signing is **conditional**: it activates only when
`build/BAUERGROUP.Shared.snk` exists. Local builds without the key succeed
(assemblies are unsigned). CI materializes the key from the
`DOTNET_SIGNKEY_BASE64` secret. The key is **never** committed (see
[`build/README.md`](../build/README.md)).

## CI/CD

[`.github/workflows/dotnet-release.yml`](../.github/workflows/dotnet-release.yml)
builds and tests on every push/PR (coverage collected), then on `main`:
semantic-release computes the version, and the packages are published to **both**
GitHub Packages and NuGet.org. See [VERSIONING.md](VERSIONING.md).
