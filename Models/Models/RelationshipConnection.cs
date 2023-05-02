using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationshipConnection
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RelationshipEntityAid { get; set; }

    public Guid? RelationshipEntityBid { get; set; }

    public string Name { get; set; } = null!;

    public Guid? RelationTypeId { get; set; }

    public string Comment { get; set; } = null!;

    public virtual RelationType? RelationType { get; set; }

    public virtual RelationshipEntity? RelationshipEntityA { get; set; }

    public virtual RelationshipEntity? RelationshipEntityB { get; set; }
}
