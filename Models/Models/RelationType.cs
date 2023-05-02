using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool ForContactContact { get; set; }

    public bool ForAccountContact { get; set; }

    public bool ForContactAccount { get; set; }

    public bool ForAccountAccount { get; set; }

    public Guid? ReverseRelationTypeId { get; set; }

    public int ProcessListeners { get; set; }

    public bool IncludeIntoContainer { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? RelationConnectionTypeId { get; set; }

    public virtual ICollection<RelationType> InverseReverseRelationType { get; set; } = new List<RelationType>();

    public virtual RelationTypePosition? Position { get; set; }

    public virtual RelationConnectionType? RelationConnectionType { get; set; }

    public virtual ICollection<RelationshipConnection> RelationshipConnections { get; set; } = new List<RelationshipConnection>();

    public virtual ICollection<Relationship> RelationshipRelationTypes { get; set; } = new List<Relationship>();

    public virtual ICollection<Relationship> RelationshipReverseRelationTypes { get; set; } = new List<Relationship>();

    public virtual RelationType? ReverseRelationType { get; set; }

    public virtual ICollection<SysRelationTypeLcz> SysRelationTypeLczs { get; set; } = new List<SysRelationTypeLcz>();
}
