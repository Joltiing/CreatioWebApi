using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityResult
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? CategoryId { get; set; }

    public bool BusinessProcessOnly { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityCategoryResultEntry> ActivityCategoryResultEntries { get; set; } = new List<ActivityCategoryResultEntry>();

    public virtual ICollection<Call> Calls { get; set; } = new List<Call>();

    public virtual ActivityResultCategory? Category { get; set; }

    public virtual ICollection<SysActivityResultLcz> SysActivityResultLczs { get; set; } = new List<SysActivityResultLcz>();
}
