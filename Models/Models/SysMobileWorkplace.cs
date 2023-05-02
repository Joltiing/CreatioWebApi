using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysMobileWorkplace
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public Guid? TypeId { get; set; }

    public virtual ICollection<SysMobileWorkplaceLcz> SysMobileWorkplaceLczs { get; set; } = new List<SysMobileWorkplaceLcz>();

    public virtual ICollection<SysRoleInMobWorkplace> SysRoleInMobWorkplaces { get; set; } = new List<SysRoleInMobWorkplace>();

    public virtual SysWorkplaceType? Type { get; set; }
}
