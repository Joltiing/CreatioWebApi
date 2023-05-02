using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAdminUnitIprange
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string BeginIp { get; set; } = null!;

    public string EndIp { get; set; } = null!;

    public Guid? SysAdminUnitId { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
