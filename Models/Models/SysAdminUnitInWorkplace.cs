using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminUnitInWorkplace
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysWorkplaceId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual SysWorkplace? SysWorkplace { get; set; }
}
