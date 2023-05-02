using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysWidgetDashboardLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? Caption { get; set; }

    public string? Items { get; set; }

    public virtual SysWidgetDashboard? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
