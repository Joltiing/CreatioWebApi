using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysReportTemplate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public byte[]? File { get; set; }

    public int Size { get; set; }

    public Guid? ReportId { get; set; }
}
