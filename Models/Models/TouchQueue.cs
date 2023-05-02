using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TouchQueue
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public int MaxRetryCount { get; set; }

    public int MessageType { get; set; }

    public string Message { get; set; } = null!;

    public int Priority { get; set; }

    public string HashCode { get; set; } = null!;
}
