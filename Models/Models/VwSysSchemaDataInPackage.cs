using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysSchemaDataInPackage
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

    public int ProcessListeners { get; set; }

    public Guid? SysSchemaId { get; set; }

    public int InstallType { get; set; }

    public Guid? Uid { get; set; }

    public bool IsChanged { get; set; }

    public bool IsLocked { get; set; }

    public string Name { get; set; } = null!;

    public bool NeedInstall { get; set; }

    public string LastError { get; set; } = null!;
}
