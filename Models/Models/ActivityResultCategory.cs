using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityResultCategory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<ActivityResult> ActivityResults { get; set; } = new List<ActivityResult>();

    public virtual ICollection<SysActivityResultCategoryLcz> SysActivityResultCategoryLczs { get; set; } = new List<SysActivityResultCategoryLcz>();
}
