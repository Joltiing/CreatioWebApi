using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityCategoryResultEntry
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ActivityResultId { get; set; }

    public Guid? ActivityCategoryId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ActivityCategory? ActivityCategory { get; set; }

    public virtual ActivityResult? ActivityResult { get; set; }
}
