# Versioning

Releases are fully automated by
[semantic-release](https://semantic-release.gitbook.io/) driven by
[Conventional Commits](https://www.conventionalcommits.org/). The version is
computed from commit messages since the last tag — there is no manual version
bumping. `semantic-release-dotnet` writes the resulting `<Version>` into
[`Directory.Build.props`](../Directory.Build.props), so all packages share one
version.

## Commit → release mapping

| Commit type | Example | Release |
| --- | --- | --- |
| `fix:` / `perf:` | `fix(erp): corrected default currency` | **patch** |
| `feat:` | `feat(crm): added Contact model` | **minor** |
| `feat!:` / `BREAKING CHANGE:` footer | `feat(models)!: rebased on Shared.Core` | **major** |
| `chore:` / `docs:` / `test:` / `refactor:` / `style:` / `ci:` / `build:` | — | *no release* |

The plugin chain lives in
[`.github/config/release/semantic-release.json`](../.github/config/release/semantic-release.json):
commit-analyzer → release-notes-generator → changelog (`CHANGELOG.md`) →
semantic-release-dotnet (`Directory.Build.props`) → git (commits both back) →
github (release + tag).

## Release history & rationale

- **1.0.0** — initial consolidation: the base package plus the Shipping, ERP,
  CRM and DMS satellites (published to GitHub Packages).
- **2.0.0** — **breaking**: the migrated models were rebased from the legacy
  `BAUERGROUP.Shared.Toolbox` foundation onto `BAUERGROUP.Shared.Core`
  (`IndependentImage`, extension helpers), ERP validity periods moved from
  `Itenso.TimePeriod` to BCL `DateTime?`, and the models gained the optional
  identity constructor. First release published to **NuGet.org** as well as
  GitHub Packages. See [MIGRATION.md](MIGRATION.md).

> semantic-release's first release on a tagless repository is `1.0.0` (not the
> `0.x` seed in `Directory.Build.props`). A subsequent `BREAKING CHANGE` then
> moves it to `2.0.0`.

## Publishing targets

On every `main` release the packages publish to:

- **GitHub Packages** (`push-to-github`)
- **NuGet.org** (`push-to-nuget`)

with symbols (`snupkg`) and SourceLink for debuggability, signed when the SNK is
available.

## Package-level API compatibility

`EnablePackageValidation` guards the multi-TFM public API surface. After a
package has a published baseline, set `PackageValidationBaselineVersion` to also
gate against accidental breaking changes between versions.
