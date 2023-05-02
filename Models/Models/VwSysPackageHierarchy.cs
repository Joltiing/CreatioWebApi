using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysPackageHierarchy
{
    public Guid? BaseSysPackageId { get; set; }

    public int Level { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? DependOnPackageId { get; set; }

    public Guid? SysWorkspaceId { get; set; }
}
