using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DeduplicateMergeRule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Sqltext { get; set; } = null!;

    public string AdditionalMergeConfig { get; set; } = null!;

    public virtual ICollection<SysDeduplicateMergeRulesLcz> SysDeduplicateMergeRulesLczs { get; set; } = new List<SysDeduplicateMergeRulesLcz>();
}
