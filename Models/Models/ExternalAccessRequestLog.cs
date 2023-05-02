using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExternalAccessRequestLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? RequestedOn { get; set; }

    public Guid? RequestedById { get; set; }

    public string Url { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public Guid? ExternalAccessId { get; set; }

    public string ExternalAccessDescription { get; set; } = null!;

    public virtual Contact? RequestedBy { get; set; }
}
