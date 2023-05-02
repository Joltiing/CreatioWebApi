using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ConnectionType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int Value { get; set; }

    public virtual ICollection<SysConnectionTypeLcz> SysConnectionTypeLczs { get; set; } = new List<SysConnectionTypeLcz>();
}
