using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleFolderMode
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<PortalSysModule> PortalSysModules { get; set; } = new List<PortalSysModule>();

    public virtual ICollection<SysModule> SysModules { get; set; } = new List<SysModule>();
}
