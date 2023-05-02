using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class DeadlineCalcSchema
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public bool Default { get; set; }

    public Guid? AlternativeRuleId { get; set; }

    public string Handler { get; set; } = null!;

    public virtual DeadlineCalcSchema? AlternativeRule { get; set; }

    public virtual ICollection<DeadlineCalcSchema> InverseAlternativeRule { get; set; } = new List<DeadlineCalcSchema>();

    public virtual ICollection<SysDeadlineCalcSchemasLcz> SysDeadlineCalcSchemasLczs { get; set; } = new List<SysDeadlineCalcSchemasLcz>();
}
