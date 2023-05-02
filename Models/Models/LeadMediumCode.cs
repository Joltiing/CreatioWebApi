using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LeadMediumCode
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Code { get; set; } = null!;

    public Guid? LeadMediumId { get; set; }

    public virtual LeadMedium? LeadMedium { get; set; }
}
