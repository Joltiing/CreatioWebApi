using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageSchemaDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public Guid? SysPackageId { get; set; }

    public bool IsLocked { get; set; }

    public bool IsChanged { get; set; }

    public Guid? SysSchemaId { get; set; }

    public byte[]? FilterData { get; set; }

    public byte[]? Data { get; set; }

    public int InstallType { get; set; }

    public bool NeedInstall { get; set; }

    public string LastError { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysPackage? SysPackage { get; set; }

    public virtual ICollection<SysPackageDataLcz> SysPackageDataLczs { get; set; } = new List<SysPackageDataLcz>();

    public virtual ICollection<SysPackageSchemaDataColumn> SysPackageSchemaDataColumns { get; set; } = new List<SysPackageSchemaDataColumn>();

    public virtual SysSchema? SysSchema { get; set; }
}
