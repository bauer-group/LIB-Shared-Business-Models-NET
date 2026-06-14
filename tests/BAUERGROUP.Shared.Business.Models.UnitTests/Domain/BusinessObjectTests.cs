using System;
using BAUERGROUP.Shared.Business.Models;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Domain;

public sealed class BusinessObjectTests
{
    private sealed class TestEntity : BusinessObject
    {
        public TestEntity() { }

        public TestEntity(Guid gUID) : base(gUID) { }
    }

    [Fact]
    public void Default_ctor_auto_generates_a_non_empty_unique_uid()
    {
        var a = new TestEntity();
        var b = new TestEntity();

        a.UID.Should().NotBe(Guid.Empty);
        a.UID.Should().NotBe(b.UID);
    }

    [Fact]
    public void Explicit_uid_ctor_assigns_the_given_identity()
    {
        var id = Guid.NewGuid();

        new TestEntity(id).UID.Should().Be(id);
    }

    [Fact]
    public void Empty_uid_ctor_falls_back_to_auto_generation()
    {
        new TestEntity(Guid.Empty).UID.Should().NotBe(Guid.Empty);
    }

    [Fact]
    public void Uid_is_settable_via_object_initializer()
    {
        var id = Guid.NewGuid();

        new TestEntity { UID = id }.UID.Should().Be(id);
    }

    [Fact]
    public void Changed_defaults_to_approximately_utc_now()
    {
        var before = DateTime.UtcNow;

        var entity = new TestEntity();

        entity.Changed.Should().BeOnOrAfter(before).And.BeOnOrBefore(DateTime.UtcNow);
    }
}
