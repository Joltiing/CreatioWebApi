using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysClientUnitSchemaSource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSchemaId { get; set; }

    public byte[]? BodyRaw { get; set; }

    public string Hash { get; set; } = null!;

    public Guid? SysCultureId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysCulture? SysCulture { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
