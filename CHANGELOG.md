# Changelog

All notable changes to this project are documented here. This file is maintained
automatically by [semantic-release](https://github.com/semantic-release/semantic-release)
on every release to `main`.

## [2.2.1](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/compare/v2.2.0...v2.2.1) (2026-10-11)

### 🐛 Bug Fixes

* **ci:** added the missing permissions block ([73d80e2](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/73d80e232ea318c4efb5f18e062868b457b29a7b))

### 🔧 Maintenance

* **ci:** removed issue AI summary workflow ([746ac0c](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/746ac0c235e45735224402e194174e286019fea3)), references [bauer-group/automation-templates#105](https://github.com/bauer-group/automation-templates/issues/105)
* **ci:** removed redundant teams notification ([1f0b4d3](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/1f0b4d34f3e6bcd7619d426545112525d572519d))

## [2.2.0](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/compare/v2.1.0...v2.2.0) (2026-07-07)

### 🚀 Features

* **models:** added ITenantScoped for tenancy ([5150053](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/5150053a155ecdb0c13f562a2d80a976ee486091))

## [2.1.0](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/compare/v2.0.0...v2.1.0) (2026-06-14)

### 🚀 Features

* **crm:** added the CRM domain model rooted on the ERP ([f4d18c7](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/f4d18c7c95f2c51dda875674019a142ca13a93e0))
* **dms:** added the DMS domain model rooted on the ERP ([5d793da](https://github.com/bauer-group/LIB-Shared-Business-Models-NET/commit/5d793da217cd85a644b5af34215c69c0ff598b9b))

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
