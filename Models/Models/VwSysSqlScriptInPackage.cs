using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysSqlScriptInPackage
{
    public Guid? SysWorkspaceId { get; set; }

    public Guid? SysPackageId { get; set; }

    public string SysPackageName { get; set; } = null!;

    public Guid? SysPackageUid { get; set; }

    public int SysPackageLevel { get; set; }

    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public int DbengineType { get; set; }

    public int InstallType { get; set; }
}
