using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysEntitySchemaInPackage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string ManagerName { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public bool ExtendParent { get; set; }

    public Guid? SysPackageUid { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? SysWorkspaceId { get; set; }

    public int SysPackageLevel { get; set; }

    public int IsVirtual { get; set; }
}
