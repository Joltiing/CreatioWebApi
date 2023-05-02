using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageDependency
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? DependOnPackageId { get; set; }

    public string DependOnPackageVersion { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysPackage? DependOnPackage { get; set; }

    public virtual SysPackage? SysPackage { get; set; }
}
