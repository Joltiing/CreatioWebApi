using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MlmodelColumn
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MlmodelId { get; set; }

    public Guid? ColumnUid { get; set; }

    public string Caption { get; set; } = null!;

    public string ColumnPath { get; set; } = null!;

    public int AggregationType { get; set; }

    public string SubFilters { get; set; } = null!;

    public Guid? ColumnTypeId { get; set; }

    public virtual MlmodelColumnType? ColumnType { get; set; }

    public virtual Mlmodel? Mlmodel { get; set; }

    public virtual ICollection<SysMlmodelColumnLcz> SysMlmodelColumnLczs { get; set; } = new List<SysMlmodelColumnLcz>();
}
