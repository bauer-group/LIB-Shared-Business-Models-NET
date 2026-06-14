using BAUERGROUP.Shared.Business.Models.Shipping;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Domain;

public sealed class ShippingTests
{
    [Fact]
    public void A_new_parcel_is_open()
    {
        new Parcel().Status.Should().Be(ParcelStatus.Open);
    }

    [Fact]
    public void A_printed_parcel_reports_printed_status()
    {
        var parcel = new Parcel { PrintCount = 1 };

        parcel.Status.Should().Be(ParcelStatus.Printed);
    }

    [Fact]
    public void A_parcel_with_a_shipment_number_is_complete()
    {
        var parcel = new Parcel { ShipmentNumber = "TRACK-123" };

        parcel.Status.Should().Be(ParcelStatus.Complete);
    }

    [Fact]
    public void A_new_shipping_image_has_no_picture()
    {
        new ShippingImage().Picture.Should().BeNull();
    }
}
