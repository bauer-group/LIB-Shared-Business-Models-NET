using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.Shipping;
using BAUERGROUP.Shared.Core.Extensions;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Domain;

public sealed class CloneTests
{
    // Uses the BAUERGROUP.Shared.Core JSON deep-clone helper. Models cloned this way
    // must round-trip through System.Text.Json (public parameterless ctor or
    // [JsonConstructor]); see docs/MIGRATION.md for the ERP types that do not yet.
    [Fact]
    public void Clone_produces_an_independent_deep_copy()
    {
        var original = new Parcel
        {
            ShipmentNumber = "TRACK-1",
            Documents = new List<ShippingDocument> { new() },
        };

        var clone = original.Clone();

        clone.Should().NotBeSameAs(original);
        clone!.ShipmentNumber.Should().Be("TRACK-1");

        // Deep copy: the collection is a different instance and mutations don't leak back.
        clone.Documents.Should().NotBeSameAs(original.Documents);
        clone.Documents.Add(new ShippingDocument());
        original.Documents.Should().ContainSingle();
    }
}
