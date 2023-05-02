using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityCategory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ActivityTypeId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityCategoryResultEntry> ActivityCategoryResultEntries { get; set; } = new List<ActivityCategoryResultEntry>();

    public virtual ActivityType? ActivityType { get; set; }

    public virtual ICollection<SysActivityCategoryLcz> SysActivityCategoryLczs { get; set; } = new List<SysActivityCategoryLcz>();
}
