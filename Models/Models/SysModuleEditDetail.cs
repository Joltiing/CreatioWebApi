using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEditDetail
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? SysModuleEditId { get; set; }

    public Guid? SysModuleGridId { get; set; }

    public int Position { get; set; }

    public string HelpContextId { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual SysModuleEdit? SysModuleEdit { get; set; }

    public virtual ICollection<SysModuleEditDetailParentAssc> SysModuleEditDetailParentAsscs { get; set; } = new List<SysModuleEditDetailParentAssc>();

    public virtual SysModuleGrid? SysModuleGrid { get; set; }
}
