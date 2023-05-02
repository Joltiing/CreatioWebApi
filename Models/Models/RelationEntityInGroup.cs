using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationEntityInGroup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RelationshipEntityId { get; set; }

    public Guid? RelationshipGroupId { get; set; }

    public string Comment { get; set; } = null!;

    public virtual RelationshipEntity? RelationshipEntity { get; set; }

    public virtual RelationshipGroup? RelationshipGroup { get; set; }
}
