using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class IntegrationLogSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? IntegrationSystemId { get; set; }

    public bool DoLog { get; set; }

    public bool LogOnlyErrors { get; set; }

    public virtual IntegrationSystem? IntegrationSystem { get; set; }
}
