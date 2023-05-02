﻿using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class FastReportTemplate
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Data { get; set; } = null!;

    public virtual ICollection<FastReportDataSource> FastReportDataSources { get; set; } = new List<FastReportDataSource>();
}
