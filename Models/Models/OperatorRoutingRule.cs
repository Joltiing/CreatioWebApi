using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OperatorRoutingRule
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<ChatQueue> ChatQueues { get; set; } = new List<ChatQueue>();

    public virtual ICollection<SysOperatorRoutingRulesLcz> SysOperatorRoutingRulesLczs { get; set; } = new List<SysOperatorRoutingRulesLcz>();
}
