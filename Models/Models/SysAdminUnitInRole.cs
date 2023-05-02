using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminUnitInRole
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public Guid? SysAdminUnitRoleId { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SourceAdminUnitId { get; set; }

    public int Source { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
