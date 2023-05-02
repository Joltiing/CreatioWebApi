using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PeriodType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<Period> Periods { get; set; } = new List<Period>();

    public virtual ICollection<SysPeriodTypeLcz> SysPeriodTypeLczs { get; set; } = new List<SysPeriodTypeLcz>();
}
