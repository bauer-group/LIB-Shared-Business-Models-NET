## [2.0.0](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/compare/v1.0.0...v2.0.0) (2026-06-14)

### ⚠ BREAKING CHANGES

* **models:** the migrated domain models are rebased from the legacy
BAUERGROUP.Shared.Toolbox foundation onto BAUERGROUP.Shared.Core
(IndependentImage, extension helpers), and ERP validity periods moved from
Itenso.TimePeriod to BCL DateTime? ValidFrom/ValidTo. Consumers of the old
BAUERGROUP.Shared.Shipping / .ERP packages must update namespaces and the
image/validity types — see docs/MIGRATION.md.

### 🚀 Features

* **models:** added optional identity constructor and modernized the source ([6d2dfe2](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/6d2dfe2880076493146d1d877762bddc1915fb9b))

## 1.0.0 (2026-06-14)

### 🚀 Features

* **models:** added ERP satellite package ([3b444f5](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/3b444f5b494db0e9f749c1e946db2bbbdd6b7dd4))
* **models:** added Shipping, CRM and DMS satellite packages ([c0dabe6](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/c0dabe6f6616c2193993e94eac38225fbf41de14))
