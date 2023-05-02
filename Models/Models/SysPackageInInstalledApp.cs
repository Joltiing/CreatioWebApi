using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPackageInInstalledApp
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysPackageId { get; set; }

    public Guid? SysInstalledAppId { get; set; }

    public int ProcessListeners { get; set; }

    public bool Primary { get; set; }

    public virtual SysInstalledApp? SysInstalledApp { get; set; }

    public virtual SysPackage? SysPackage { get; set; }
}
