using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Report
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<ReportInFolder> ReportInFolders { get; set; } = new List<ReportInFolder>();

    public virtual ICollection<SysReportRight> SysReportRights { get; set; } = new List<SysReportRight>();
}
