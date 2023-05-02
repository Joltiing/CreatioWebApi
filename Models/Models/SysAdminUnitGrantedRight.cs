using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminUnitGrantedRight
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? GrantorSysAdminUnitId { get; set; }

    public Guid? GranteeSysAdminUnitId { get; set; }

    public int ProcessListeners { get; set; }
}
