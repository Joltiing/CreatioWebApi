using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysStoringObjectState
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysGridPageView> SysGridPageViews { get; set; } = new List<SysGridPageView>();

    public virtual ICollection<SysStoringObjectStateLcz> SysStoringObjectStateLczs { get; set; } = new List<SysStoringObjectStateLcz>();
}
