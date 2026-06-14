using System;
using BAUERGROUP.Shared.Business.Models.CRM;
using BAUERGROUP.Shared.Business.Models.ERP;
using BAUERGROUP.Shared.Core.Extensions;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Domain;

public sealed class CrmTests
{
    [Fact]
    public void New_account_is_a_business_associate_with_identity_and_neutral_defaults()
    {
        var account = new CRMAccount();

        // Reuses the ERP party surface as its base class.
        account.Should().BeAssignableTo<ERPBusinessAssociate>();

        account.UID.Should().NotBe(Guid.Empty);
        account.ClientUID.Should().Be(Guid.Empty);
        account.Industry.Should().Be(CRMIndustry.Unspecified);
        account.AccountType.Should().Be(CRMAccountType.Unspecified);
        account.Links.Should().BeEmpty();
    }

    [Fact]
    public void Contact_status_is_independent_of_the_inherited_address_status()
    {
        var contact = new CRMContact();

        // CRM engagement state and the inherited ERP address status are distinct members.
        contact.ContactStatus.Should().Be(CRMContactStatus.Active);
        contact.Status.Should().Be(ERPAddressStatus.Active);
    }

    [Fact]
    public void Weighted_amount_reflects_probability()
    {
        var opportunity = new CRMOpportunity { Amount = 1000m, Probability = 25m };

        opportunity.WeightedAmount.Should().Be(250m);
    }

    [Fact]
    public void Opportunity_line_total_applies_the_rebate()
    {
        var line = new CRMOpportunityLine { Quantity = 2m, UnitPrice = 100m, Rebate = 10m };

        line.TotalPrice.Should().Be(180m);
    }

    [Fact]
    public void Opportunity_clone_is_an_independent_deep_copy()
    {
        var original = new CRMOpportunity { Name = "Deal", Amount = 500m, Currency = ERPCurrency.EUR };
        original.Lines.Add(new CRMOpportunityLine { Quantity = 1m, UnitPrice = 500m });

        var clone = original.Clone();

        clone.Should().NotBeSameAs(original);
        clone!.Name.Should().Be("Deal");
        clone.Lines.Should().NotBeSameAs(original.Lines);
        clone.Lines.Add(new CRMOpportunityLine());
        original.Lines.Should().ContainSingle();
    }
}
