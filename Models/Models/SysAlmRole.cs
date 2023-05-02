using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAlmRole
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Code { get; set; } = null!;

    public Guid? RoleId { get; set; }

    public virtual SysAdminUnit? Role { get; set; }
}
