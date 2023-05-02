using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class RuleRelation
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public Guid? EntitySchemaColumnUid { get; set; }

    public Guid? EntitySchemaSearchUid { get; set; }

    public Guid? EntitySchemaSearchColumnUid { get; set; }

    public string Rule { get; set; } = null!;

    public int Position { get; set; }

    public virtual ICollection<SysRuleRelationLcz> SysRuleRelationLczs { get; set; } = new List<SysRuleRelationLcz>();
}
