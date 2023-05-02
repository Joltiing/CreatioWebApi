using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysEntityPrcStartEvent
{
    public Guid Id { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public int RecordChangeType { get; set; }

    public Guid? ProcessSchemaId { get; set; }

    public Guid? ProcessSchemaElementUid { get; set; }

    public string ConditionData { get; set; } = null!;

    public string ChangedColumns { get; set; } = null!;

    public bool WaitingRandomSignal { get; set; }

    public string Signal { get; set; } = null!;

    public Guid? SysWorkspaceId { get; set; }

    public string ManagerName { get; set; } = null!;
}
