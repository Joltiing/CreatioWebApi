using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPortal
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SysModuleEntityInPortal> SysModuleEntityInPortals { get; set; } = new List<SysModuleEntityInPortal>();
}
