using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcPersistentStore
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string GroupKey { get; set; } = null!;

    public string Key { get; set; } = null!;

    public byte[]? Value { get; set; }

    public int ProcessListeners { get; set; }
}
