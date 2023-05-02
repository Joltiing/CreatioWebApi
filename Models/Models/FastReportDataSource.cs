using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FastReportDataSource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Data { get; set; } = null!;

    public Guid? TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public virtual FastReportTemplate? Template { get; set; }

    public virtual FrdataSourceType? Type { get; set; }
}
