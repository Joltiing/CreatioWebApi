using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Month
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Number { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysMonthLcz> SysMonthLczs { get; set; } = new List<SysMonthLcz>();
}
