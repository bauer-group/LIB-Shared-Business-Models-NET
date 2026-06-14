using System;
using BAUERGROUP.Shared.Business.Models.DMS;
using BAUERGROUP.Shared.Business.Models.ERP;
using BAUERGROUP.Shared.Core.Extensions;
using FluentAssertions;
using Xunit;

namespace BAUERGROUP.Shared.Business.Models.UnitTests.Domain;

public sealed class DmsTests
{
    [Fact]
    public void New_document_has_neutral_defaults_and_owns_its_retention()
    {
        var document = new DMSDocument();

        document.UID.Should().NotBe(Guid.Empty);
        document.Status.Should().Be(DMSDocumentStatus.Draft);
        document.Classification.Should().Be(DMSSecurityClassification.Internal);
        document.Retention.Should().NotBeNull();
        document.Versions.Should().BeEmpty();
        document.Workflows.Should().BeEmpty();
        document.Deadlines.Should().BeEmpty();
        document.FullText.Should().BeNull();
    }

    [Fact]
    public void Invoice_approval_workflow_aggregates_its_steps()
    {
        var workflow = new DMSWorkflow
        {
            Type = DMSWorkflowType.InvoiceApproval,
            Mode = DMSWorkflowMode.Sequential,
            Status = DMSWorkflowStatus.InProgress,
        };
        workflow.Steps.Add(new DMSWorkflowStep { Order = 1, Decision = DMSApprovalDecision.Approved });
        workflow.Steps.Add(new DMSWorkflowStep { Order = 2, Decision = DMSApprovalDecision.Pending });

        workflow.Steps.Should().HaveCount(2);
        workflow.IsComplete.Should().BeFalse();
    }

    [Fact]
    public void Deadline_defaults_to_an_open_resubmission()
    {
        var deadline = new DMSDeadline();

        deadline.Type.Should().Be(DMSDeadlineType.Resubmission);
        deadline.Status.Should().Be(DMSDeadlineStatus.Open);
        deadline.Priority.Should().Be(ERPPriority.Normal);
    }

    [Fact]
    public void Rendition_reuses_the_erp_attachment_payload()
    {
        var rendition = new DMSRendition();

        // Inherits the polymorphic File/Embedded/URI payload from ERPAttachment.
        rendition.Should().BeAssignableTo<ERPAttachment>();
        rendition.Mode.Should().Be(ERPAttachmentMode.File);
        rendition.RenditionType.Should().Be(DMSRenditionType.Original);
        rendition.PDFALevel.Should().Be(DMSPDFALevel.None);
    }

    [Fact]
    public void Document_status_flags_combine()
    {
        var document = new DMSDocument { Status = DMSDocumentStatus.Released | DMSDocumentStatus.CheckedOut };

        document.IsCheckedOut.Should().BeTrue();
        document.IsArchived.Should().BeFalse();
    }

    [Fact]
    public void Full_control_permission_is_the_union_of_individual_rights()
    {
        DMSPermission.FullControl.HasFlag(DMSPermission.Read).Should().BeTrue();
        DMSPermission.FullControl.HasFlag(DMSPermission.Sign).Should().BeTrue();
        DMSPermission.FullControl.HasFlag(DMSPermission.Delete).Should().BeTrue();
    }

    [Fact]
    public void Retention_policy_can_model_a_gobd_tax_period()
    {
        var policy = new DMSRetentionPolicy
        {
            Category = DMSRetentionCategory.TaxRelevant,
            LegalBasis = DMSRetentionLegalBasis.AO_147,
            RetentionYears = 10,
        };

        policy.RetentionYears.Should().Be(10);
        policy.LegalBasis.Should().Be(DMSRetentionLegalBasis.AO_147);
    }

    [Fact]
    public void Audit_entry_clone_is_an_independent_deep_copy()
    {
        var original = new DMSAuditEntry { Action = DMSAuditAction.Viewed, PrincipalName = "alice" };

        var clone = original.Clone();

        clone.Should().NotBeSameAs(original);
        clone!.Action.Should().Be(DMSAuditAction.Viewed);
        clone.PrincipalName.Should().Be("alice");
        clone.UID.Should().Be(original.UID);
    }
}
