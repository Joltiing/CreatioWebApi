using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntityCommonPrcEl
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? ProcessElementId { get; set; }

    public string ConditionData { get; set; } = null!;

    public string ChangedColumns { get; set; } = null!;

    public int RecordChangeType { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysProcessElementDatum? ProcessElement { get; set; }
}
