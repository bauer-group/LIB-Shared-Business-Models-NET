using System.Reflection;
using BAUERGROUP.Shared.Business.Models;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.Shipping;
using FluentAssertions;
using NetArchTest.Rules;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Architecture;

/// <summary>
/// Enforces the model dependency DAG: the base package is dependency-free, and the
/// domain satellites only depend "downward" (never sideways onto each other).
/// </summary>
public sealed class DependencyTests
{
    private static readonly Assembly BasePackage = typeof(Business).Assembly;
    private static readonly Assembly ShippingPackage = typeof(Parcel).Assembly;
    private static readonly Assembly ErpPackage = typeof(ERPObjectBase).Assembly;

    [Fact]
    public void Base_package_depends_on_neither_satellites_nor_core()
    {
        var result = Types.InAssembly(BasePackage)
            .ShouldNot()
            .HaveDependencyOnAny(
                "BAUERGROUP.Shared.Business.Models.Shipping",
                "BAUERGROUP.Shared.Business.Models.ERP",
                "BAUERGROUP.Shared.Business.Models.CRM",
                "BAUERGROUP.Shared.Business.Models.DMS",
                "BAUERGROUP.Shared.Core")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Shipping_does_not_depend_on_erp()
    {
        var result = Types.InAssembly(ShippingPackage)
            .ShouldNot()
            .HaveDependencyOn("BAUERGROUP.Shared.Business.Models.ERP")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Erp_does_not_depend_on_crm_or_dms()
    {
        var result = Types.InAssembly(ErpPackage)
            .ShouldNot()
            .HaveDependencyOnAny(
                "BAUERGROUP.Shared.Business.Models.CRM",
                "BAUERGROUP.Shared.Business.Models.DMS")
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
