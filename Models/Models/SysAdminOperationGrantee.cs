using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminOperationGrantee
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysAdminOperationId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public bool CanExecute { get; set; }

    public int Position { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysAdminOperation? SysAdminOperation { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
