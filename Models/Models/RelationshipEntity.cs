using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationshipEntity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SchemaUid { get; set; }

    public virtual ICollection<RelationEntInDiagram> RelationEntInDiagrams { get; set; } = new List<RelationEntInDiagram>();

    public virtual ICollection<RelationEntityInGroup> RelationEntityInGroups { get; set; } = new List<RelationEntityInGroup>();

    public virtual ICollection<RelationshipConnection> RelationshipConnectionRelationshipEntityAs { get; set; } = new List<RelationshipConnection>();

    public virtual ICollection<RelationshipConnection> RelationshipConnectionRelationshipEntityBs { get; set; } = new List<RelationshipConnection>();
}
