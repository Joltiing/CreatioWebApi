using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MultiDeleteQueue
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public string Message { get; set; } = null!;

    public Guid? DenyReasonId { get; set; }

    public Guid? OperationKey { get; set; }

    public int State { get; set; }

    public Guid? EntitySchemaUid { get; set; }

    public bool IsRoot { get; set; }

    public virtual MultiDeleteDenyReason? DenyReason { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
