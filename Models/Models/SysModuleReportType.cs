using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleReportType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysModuleAnalyticsReport> SysModuleAnalyticsReports { get; set; } = new List<SysModuleAnalyticsReport>();

    public virtual ICollection<SysModuleReportTypeLcz> SysModuleReportTypeLczs { get; set; } = new List<SysModuleReportTypeLcz>();

    public virtual ICollection<SysModuleReport> SysModuleReports { get; set; } = new List<SysModuleReport>();
}
