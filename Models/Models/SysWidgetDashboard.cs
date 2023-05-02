using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysWidgetDashboard
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Caption { get; set; } = null!;

    public int Position { get; set; }

    public string ViewConfig { get; set; } = null!;

    public string Items { get; set; } = null!;

    public Guid? SectionId { get; set; }

    public virtual SysModule? Section { get; set; }

    public virtual ICollection<SysWidgetDashboardLcz> SysWidgetDashboardLczs { get; set; } = new List<SysWidgetDashboardLcz>();
}
