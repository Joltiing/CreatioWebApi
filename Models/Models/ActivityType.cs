using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityType
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

    public byte[]? TypeImage { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityCategory> ActivityCategories { get; set; } = new List<ActivityCategory>();

    public virtual ICollection<ActivityTypeStatusEntry> ActivityTypeStatusEntries { get; set; } = new List<ActivityTypeStatusEntry>();

    public virtual ICollection<SysActivityTypeLcz> SysActivityTypeLczs { get; set; } = new List<SysActivityTypeLcz>();
}
