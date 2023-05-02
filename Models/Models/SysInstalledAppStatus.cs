using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysInstalledAppStatus
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysInstalledAppStatusLcz> SysInstalledAppStatusLczs { get; set; } = new List<SysInstalledAppStatusLcz>();

    public virtual ICollection<SysInstalledApp> SysInstalledApps { get; set; } = new List<SysInstalledApp>();
}
