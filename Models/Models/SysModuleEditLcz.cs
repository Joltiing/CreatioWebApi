using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEditLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? ActionKindCaption { get; set; }

    public string? PageCaption { get; set; }

    public virtual SysModuleEdit? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
