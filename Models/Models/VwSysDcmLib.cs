using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysDcmLib
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public Guid? PackageUid { get; set; }

    public Guid? PackageId { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public Guid? ParentId { get; set; }

    public bool IsLocked { get; set; }

    public bool ExtendParent { get; set; }

    public Guid? StageColumnUid { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public bool? IsActive { get; set; }

    public string? Filters { get; set; }

    public int? Version { get; set; }

    public Guid? VersionParentId { get; set; }

    public Guid? VersionParentUid { get; set; }

    public bool? IsActiveVersion { get; set; }
}
