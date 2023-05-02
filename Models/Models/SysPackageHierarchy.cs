using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageHierarchy
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? BaseSysPackageId { get; set; }

    public int Level { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? DependOnPackageId { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysPackage? BaseSysPackage { get; set; }

    public virtual SysPackage? DependOnPackage { get; set; }

    public virtual SysPackage? SysPackage { get; set; }

    public virtual SysWorkspace? SysWorkspace { get; set; }
}
