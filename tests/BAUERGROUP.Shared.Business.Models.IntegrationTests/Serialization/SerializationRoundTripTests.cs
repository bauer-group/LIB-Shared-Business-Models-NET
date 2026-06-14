using System;
using System.Collections.Generic;
using System.Text.Json;
using BAUERGROUP.Shared.Business.Models.ERP;
using BAUERGROUP.Shared.Business.Models.Shipping;
using BAUERGROUP.Shared.Core.Images;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.IntegrationTests.Serialization;

/// <summary>
/// System.Text.Json round-trips that also exercise cross-package wiring
/// (Shipping -> Core.IndependentImage, ERP -> base identity).
/// </summary>
[Trait("Category", "Integration")]
public sealed class SerializationRoundTripTests
{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.General);

    [Fact]
    public void Parcel_with_image_round_trips_through_json()
    {
        var parcel = new Parcel
        {
            ShipmentNumber = "TRACK-1",
            Weight = 2.5m,
            Images = new List<ShippingImage>
            {
                new() { Picture = new IndependentImage { Content = new byte[] { 1, 2, 3 } } },
            },
        };

        var json = JsonSerializer.Serialize(parcel, Options);
        var back = JsonSerializer.Deserialize<Parcel>(json, Options)!;

        back.ShipmentNumber.Should().Be("TRACK-1");
        back.Weight.Should().Be(2.5m);
        back.Images.Should().ContainSingle();
        back.Images[0].Picture!.Content.Should().Equal(new byte[] { 1, 2, 3 });
    }

    [Fact]
    public void Erp_product_prices_round_trips_preserving_identity_and_validity()
    {
        var prices = new ERPProductPrices
        {
            Price = 9.99m,
            ValidFrom = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
        };

        var json = JsonSerializer.Serialize(prices, Options);
        var back = JsonSerializer.Deserialize<ERPProductPrices>(json, Options)!;

        back.UID.Should().Be(prices.UID);
        back.Price.Should().Be(9.99m);
        back.ValidFrom.Should().Be(prices.ValidFrom);
        back.ValidTo.Should().BeNull();
    }
}
