using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntityPrcStartEvent
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? ProcessSchemaId { get; set; }

    public Guid? ProcessSchemaElementUid { get; set; }

    public int RecordChangeType { get; set; }

    public string ConditionData { get; set; } = null!;

    public string ChangedColumns { get; set; } = null!;

    public bool WaitingRandomSignal { get; set; }

    public string Signal { get; set; } = null!;

    public Guid? EntitySchemaUid { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSchema? ProcessSchema { get; set; }
}
