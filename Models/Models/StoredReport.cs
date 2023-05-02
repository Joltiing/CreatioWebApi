using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class StoredReport
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Caption { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte[]? Data { get; set; }

    public virtual ICollection<StoredReportResource> StoredReportResources { get; set; } = new List<StoredReportResource>();

    public virtual ICollection<SysStoredReportLcz> SysStoredReportLczs { get; set; } = new List<SysStoredReportLcz>();
}
