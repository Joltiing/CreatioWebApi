using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysWorkspace
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int Number { get; set; }

    public int Version { get; set; }

    public byte[]? AssemblyData { get; set; }

    public string RepositoryUri { get; set; } = null!;

    public string WorkingCopyPath { get; set; } = null!;

    public int RepositoryRevisionNumber { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? BuildOdataStartedById { get; set; }

    public virtual Contact? BuildOdataStartedBy { get; set; }

    public virtual ICollection<SysPackageHierarchy> SysPackageHierarchies { get; set; } = new List<SysPackageHierarchy>();

    public virtual ICollection<SysPackageModule> SysPackageModules { get; set; } = new List<SysPackageModule>();

    public virtual ICollection<SysPackage> SysPackages { get; set; } = new List<SysPackage>();
}
