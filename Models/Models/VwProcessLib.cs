﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwProcessLib
{
    public Guid? Id { get; set; }

    public Guid SysSchemaId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string ManagerName { get; set; } = null!;

    public Guid? Uid { get; set; }

    public Guid? ParentId { get; set; }

    public bool ExtendParent { get; set; }

    public bool IsChanged { get; set; }

    public bool IsLocked { get; set; }

    public byte[]? MetaData { get; set; }

    public DateTime? MetaDataModifiedOn { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? PackageUid { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public string Description { get; set; } = null!;

    public bool? NeedUpdateSourceCode { get; set; }

    public bool? NeedUpdateStructure { get; set; }

    public bool? NeedInstall { get; set; }

    public bool? IsMaxVersion { get; set; }

    public bool? Enabled { get; set; }

    public string TagProperty { get; set; } = null!;

    public int? Version { get; set; }

    public Guid? ProcessSchemaTypeId { get; set; }

    public bool? AddToRunButton { get; set; }

    public bool? IsActiveVersion { get; set; }

    public Guid? VersionParentId { get; set; }

    public Guid? VersionParentUid { get; set; }

    public bool? HasStartEvent { get; set; }

    public Guid? StartOptionsImageId { get; set; }

    public bool? IsProcessTracing { get; set; }
}
