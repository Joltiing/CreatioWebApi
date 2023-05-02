using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModulePrimaryGrid
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysModuleId { get; set; }

    public Guid? SysModuleGridId { get; set; }

    public int Position { get; set; }

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysModule? SysModule { get; set; }

    public virtual SysModuleGrid? SysModuleGrid { get; set; }
}
