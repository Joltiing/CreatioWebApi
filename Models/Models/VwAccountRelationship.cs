using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAccountRelationship
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? RelatedContactId { get; set; }

    public Guid? RelatedAccountId { get; set; }

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public Guid RelationTypeId { get; set; }

    public Guid ReverseRelationTypeId { get; set; }

    public string? RelatedObjectName { get; set; }
}
