using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageModule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? SysWorkspaceId { get; set; }

    public byte[]? Data { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysWorkspace? SysWorkspace { get; set; }
}
