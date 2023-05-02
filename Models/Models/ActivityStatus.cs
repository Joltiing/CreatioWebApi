using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityStatus
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

    public bool Finish { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityTypeStatusEntry> ActivityTypeStatusEntries { get; set; } = new List<ActivityTypeStatusEntry>();

    public virtual ICollection<SysActivityStatusLcz> SysActivityStatusLczs { get; set; } = new List<SysActivityStatusLcz>();
}
