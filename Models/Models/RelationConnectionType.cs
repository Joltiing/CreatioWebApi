using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationConnectionType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<RelationType> RelationTypes { get; set; } = new List<RelationType>();

    public virtual ICollection<SysRelationConnectionTypeLcz> SysRelationConnectionTypeLczs { get; set; } = new List<SysRelationConnectionTypeLcz>();
}
