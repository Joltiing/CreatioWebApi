using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysParentAssociationType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysModuleDetailParentAssc> SysModuleDetailParentAsscs { get; set; } = new List<SysModuleDetailParentAssc>();

    public virtual ICollection<SysModuleEditDetailParentAssc> SysModuleEditDetailParentAsscs { get; set; } = new List<SysModuleEditDetailParentAssc>();
}
