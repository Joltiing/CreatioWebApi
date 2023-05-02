﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysSchemaInfoNew
{
    public Guid? Id { get; set; }

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

    public byte[]? MetaData { get; set; }

    public Guid? SysPackageId { get; set; }

    public string PackageName { get; set; } = null!;

    public Guid? SysWorkspaceId { get; set; }
}
