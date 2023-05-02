using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationshipGroup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public virtual ICollection<RelationEntityInGroup> RelationEntityInGroups { get; set; } = new List<RelationEntityInGroup>();
}
