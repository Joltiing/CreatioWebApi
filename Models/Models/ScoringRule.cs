using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ScoringRule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ScoringModelId { get; set; }

    public string FilterData { get; set; } = null!;

    public int ScoringCount { get; set; }

    public decimal ScoringPoints { get; set; }

    public int Duration { get; set; }

    public virtual ScoringModel? ScoringModel { get; set; }
}
