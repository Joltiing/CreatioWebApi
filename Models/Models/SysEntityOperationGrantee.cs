using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntityOperationGrantee
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysSchemaUid { get; set; }

    public Guid? SysEntityOperationId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual SysEntityOperation? SysEntityOperation { get; set; }
}
