# Semantic-release configuration

`semantic-release.json` is consumed by the `bauer-group/automation-templates/.github/workflows/modules-semantic-release.yml` reusable workflow.

## Plugins

| Plugin | Purpose |
|---|---|
| `@semantic-release/commit-analyzer` | Inspects conventional commits since the last release to decide the bump |
| `@semantic-release/release-notes-generator` | Builds the markdown notes |
| `@semantic-release/changelog` | Writes the new release section to `CHANGELOG.md` |
| `semantic-release-dotnet` | Writes the new `<Version>` into `Directory.Build.props` |
| `@semantic-release/git` | Commits `CHANGELOG.md` + `Directory.Build.props` back with `chore(release): ${version} [automated]` |
| `@semantic-release/github` | Creates the GitHub Release + tag |

## Conventional-commit bump rules (pre-1.0)

- `feat:` / `fix:` / `perf:` → patch or minor
- `feat!:` or `BREAKING CHANGE:` footer → minor (pre-1.0) or major (post-1.0)
- `chore:` / `docs:` / `test:` / `refactor:` / `style:` / `ci:` → no release

See `docs/VERSIONING.md` for the full policy.
