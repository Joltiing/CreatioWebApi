using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysPageSchemaInWorkspace
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ManagerName { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public bool ExtendParent { get; set; }

    public bool IsChanged { get; set; }

    public bool IsLocked { get; set; }

    public DateTime? MetaDataModifiedOn { get; set; }

    public byte[]? MetaData { get; set; }

    public Guid? PackageUid { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public bool? NeedUpdateSourceCode { get; set; }

    public bool? NeedUpdateStructure { get; set; }

    public bool? NeedInstall { get; set; }
}
