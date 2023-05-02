using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwProcessStartEvent
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EntitySchemaName { get; set; } = null!;

    public string RecordChangeTypeName { get; set; } = null!;

    public Guid? ProcessElementUid { get; set; }

    public Guid? ProcessUid { get; set; }

    public string? ElementName { get; set; }
}
