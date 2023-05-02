using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class TimeUnit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int Position { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<SysTimeUnitLcz> SysTimeUnitLczs { get; set; } = new List<SysTimeUnitLcz>();
}
