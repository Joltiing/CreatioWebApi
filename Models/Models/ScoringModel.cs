using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ScoringModel
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public Guid? SourceModelId { get; set; }

    public Guid? ScoringObjectId { get; set; }

    public Guid? ColumnUid { get; set; }

    public string ColumnCaption { get; set; } = null!;

    public virtual ICollection<ScoringRule> ScoringRules { get; set; } = new List<ScoringRule>();
}
