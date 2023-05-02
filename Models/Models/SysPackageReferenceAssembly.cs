using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageReferenceAssembly
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public Guid? SysPackageId { get; set; }

    public bool IsLocked { get; set; }

    public bool IsChanged { get; set; }

    public string FullName { get; set; } = null!;

    public byte[]? Data { get; set; }

    public bool LoadOnAppStart { get; set; }

    public bool IsNetStandard { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysPackage? SysPackage { get; set; }
}
