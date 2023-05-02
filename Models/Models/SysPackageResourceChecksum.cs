using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageResourceChecksum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? SysSchemaId { get; set; }

    public string ResourceManager { get; set; } = null!;

    public Guid? SysCultureId { get; set; }

    public bool IsChanged { get; set; }

    public string Checksum { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string SysSchemaName { get; set; } = null!;

    public virtual SysCulture? SysCulture { get; set; }

    public virtual SysPackage? SysPackage { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
