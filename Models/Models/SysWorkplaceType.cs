using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysWorkplaceType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public int Code { get; set; }

    public virtual ICollection<SysMobileWorkplace> SysMobileWorkplaces { get; set; } = new List<SysMobileWorkplace>();

    public virtual ICollection<SysWorkplaceTypeLcz> SysWorkplaceTypeLczs { get; set; } = new List<SysWorkplaceTypeLcz>();

    public virtual ICollection<SysWorkplace> SysWorkplaces { get; set; } = new List<SysWorkplace>();
}
