using System;
using BAUERGROUP.Shared.Business.Models.ERP;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Domain;

public sealed class ErpTests
{
    [Fact]
    public void New_product_prices_has_unbounded_validity_and_sensible_defaults()
    {
        var prices = new ERPProductPrices();

        prices.ValidFrom.Should().BeNull();
        prices.ValidTo.Should().BeNull();
        prices.Quantity.Should().Be(1m);
        prices.Currency.Should().Be(ERPCurrency.EUR);
        prices.UID.Should().NotBe(Guid.Empty);
        prices.ClientUID.Should().Be(Guid.Empty);
    }

    [Fact]
    public void New_picture_license_has_unbounded_validity()
    {
        var license = new ERPPictureLicense();

        license.ValidFrom.Should().BeNull();
        license.ValidTo.Should().BeNull();
        license.Licensor.Should().Be(ERPPictureLicensor.OwnCreation);
    }

    [Fact]
    public void Erp_object_base_explicit_uid_ctor_assigns_identity()
    {
        var id = Guid.NewGuid();

        new ERPObjectBase(id).UID.Should().Be(id);
    }
}
