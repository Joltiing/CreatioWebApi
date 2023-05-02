using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AdminUnitFeatureState
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public int FeatureState { get; set; }

    public Guid? FeatureId { get; set; }

    public virtual Feature? Feature { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
