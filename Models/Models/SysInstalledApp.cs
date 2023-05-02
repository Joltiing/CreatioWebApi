using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysInstalledApp
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Maintainer { get; set; } = null!;

    public DateTime? InstallDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string MarketplaceLink { get; set; } = null!;

    public string HelpLink { get; set; } = null!;

    public string FileLink { get; set; } = null!;

    public string SupportEmail { get; set; } = null!;

    public string OrderLink { get; set; } = null!;

    public Guid? SysInstalledAppStatusId { get; set; }

    public int ProcessListeners { get; set; }

    public string MkpPublishedVersion { get; set; } = null!;

    public string MkpReleaseNotes { get; set; } = null!;

    public bool MkpNotificationStatus { get; set; }

    public DateTime? MkpChangedOn { get; set; }

    public bool MkpIsUpdated { get; set; }

    public Guid? IconId { get; set; }

    public string IconBackground { get; set; } = null!;

    public virtual SysImage? Icon { get; set; }

    public virtual SysInstalledAppStatus? SysInstalledAppStatus { get; set; }

    public virtual ICollection<SysPackageInInstalledApp> SysPackageInInstalledApps { get; set; } = new List<SysPackageInInstalledApp>();
}
