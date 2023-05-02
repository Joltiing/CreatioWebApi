using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageSqlScript
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public Guid? Uid { get; set; }

    public Guid? SysPackageId { get; set; }

    public int DbengineType { get; set; }

    public int InstallType { get; set; }

    public byte[]? Body { get; set; }

    public bool IsChanged { get; set; }

    public bool IsLocked { get; set; }

    public bool NeedInstall { get; set; }

    public string LastError { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysPackage? SysPackage { get; set; }

    public virtual ICollection<SysSqlScriptDependency> SysSqlScriptDependencyDependOnSqlScripts { get; set; } = new List<SysSqlScriptDependency>();

    public virtual ICollection<SysSqlScriptDependency> SysSqlScriptDependencySysSqlScripts { get; set; } = new List<SysSqlScriptDependency>();
}
