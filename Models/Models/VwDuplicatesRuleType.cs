using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwDuplicatesRuleType
{
    public Guid? Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? Uid { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;
}
