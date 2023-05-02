using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Relationship
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? RelationTypeId { get; set; }

    public Guid? ReverseRelationTypeId { get; set; }

    public bool Active { get; set; }

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? AccountAid { get; set; }

    public Guid? ContactAid { get; set; }

    public Guid? AccountBid { get; set; }

    public Guid? ContactBid { get; set; }

    public virtual Account? AccountA { get; set; }

    public virtual Account? AccountB { get; set; }

    public virtual Contact? ContactA { get; set; }

    public virtual Contact? ContactB { get; set; }

    public virtual RelationType? RelationType { get; set; }

    public virtual RelationType? ReverseRelationType { get; set; }
}
