using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CompletenessParameter
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? CompletenessId { get; set; }

    public string Name { get; set; } = null!;

    public Guid? AttributeId { get; set; }

    public int Percentage { get; set; }

    public bool IsColumn { get; set; }

    public bool IsDetail { get; set; }

    public string ColumnName { get; set; } = null!;

    public string DetailEntityName { get; set; } = null!;

    public string DetailColumn { get; set; } = null!;

    public string MasterColumn { get; set; } = null!;

    public string TypeColumn { get; set; } = null!;

    public Guid? TypeValue { get; set; }

    public virtual Completeness? Completeness { get; set; }

    public virtual ICollection<SysCompletenessParameterLcz> SysCompletenessParameterLczs { get; set; } = new List<SysCompletenessParameterLcz>();
}
