using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TouchEventLog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public bool HasErrors { get; set; }

    public string ErrorDetails { get; set; } = null!;

    public Guid? TrackingId { get; set; }

    public string MessageTypeName { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public int Amount { get; set; }

    public virtual ICollection<SysTouchEventLogLcz> SysTouchEventLogLczs { get; set; } = new List<SysTouchEventLogLcz>();
}
