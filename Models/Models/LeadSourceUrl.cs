using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LeadSourceUrl
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Url { get; set; } = null!;

    public Guid? LeadSourceId { get; set; }

    public virtual LeadSource? LeadSource { get; set; }
}
