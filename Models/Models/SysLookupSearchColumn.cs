using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLookupSearchColumn
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysLookupId { get; set; }

    public string MetaPath { get; set; } = null!;

    public int Position { get; set; }

    public string MetaCaption { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysLookup? SysLookup { get; set; }
}
