using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcElMilog
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? IteratorElementId { get; set; }

    public int IterationNumber { get; set; }

    public virtual SysProcessElementLog? IteratorElement { get; set; }
}
