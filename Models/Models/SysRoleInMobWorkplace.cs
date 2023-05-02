using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysRoleInMobWorkplace
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysRoleId { get; set; }

    public Guid? SysMobileWorkplaceId { get; set; }

    public virtual SysMobileWorkplace? SysMobileWorkplace { get; set; }

    public virtual SysAdminUnit? SysRole { get; set; }
}
