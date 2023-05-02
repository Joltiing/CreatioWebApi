using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProcessIntermediateEvent
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysProcessElementId { get; set; }

    public string Message { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysProcessElementDatum? SysProcessElement { get; set; }
}
