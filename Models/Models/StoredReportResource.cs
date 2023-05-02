using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class StoredReportResource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public Guid? DevExpressReportId { get; set; }

    public virtual StoredReport? DevExpressReport { get; set; }

    public virtual ICollection<SysStoredReportResourcesLcz> SysStoredReportResourcesLczs { get; set; } = new List<SysStoredReportResourcesLcz>();
}
