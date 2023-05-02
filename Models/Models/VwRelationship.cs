using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwRelationship
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ContactAid { get; set; }

    public Guid? AccountAid { get; set; }

    public Guid? ContactBid { get; set; }

    public Guid? AccountBid { get; set; }

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public string? Our { get; set; }

    public string? Related { get; set; }

    public string OutputRelationType { get; set; } = null!;

    public string OutputReverseRelationType { get; set; } = null!;
}
