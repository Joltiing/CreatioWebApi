using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEditLczOld
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? ColumnUid { get; set; }

    public Guid? SysCultureId { get; set; }

    public string Value { get; set; } = null!;

    public virtual SysModuleEdit? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
