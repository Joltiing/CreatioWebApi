using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityCorrespondence
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ActivityId { get; set; }

    public bool IsDeleted { get; set; }

    public string SourceActivityId { get; set; } = null!;

    public Guid? SourceAccountId { get; set; }

    public bool CreatedInBpmonline { get; set; }
}
