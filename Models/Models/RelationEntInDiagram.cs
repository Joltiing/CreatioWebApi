using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RelationEntInDiagram
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RelationshipDiagramId { get; set; }

    public Guid? RelationshipEntityId { get; set; }

    public virtual RelationshipDiagram? RelationshipDiagram { get; set; }

    public virtual RelationshipEntity? RelationshipEntity { get; set; }
}
