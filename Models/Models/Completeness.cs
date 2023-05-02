using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Completeness
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string EntitySchemaName { get; set; } = null!;

    public string TypeColumnName { get; set; } = null!;

    public Guid? TypeColumnValue { get; set; }

    public string ResultColumnName { get; set; } = null!;

    public string Scale { get; set; } = null!;

    public virtual ICollection<CompletenessParameter> CompletenessParameters { get; set; } = new List<CompletenessParameter>();

    public virtual ICollection<SysCompletenessLcz> SysCompletenessLczs { get; set; } = new List<SysCompletenessLcz>();
}
