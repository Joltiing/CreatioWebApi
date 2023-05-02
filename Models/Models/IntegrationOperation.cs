using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class IntegrationOperation
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<IntegrationLog> IntegrationLogs { get; set; } = new List<IntegrationLog>();

    public virtual ICollection<SysIntegrationOperationLcz> SysIntegrationOperationLczs { get; set; } = new List<SysIntegrationOperationLcz>();
}
