using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwLogObject
{
    public Guid Id { get; set; }

    public Guid? Uid { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? CreatedById { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysWorkspaceId { get; set; }
}
