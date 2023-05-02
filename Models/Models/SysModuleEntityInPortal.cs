using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysModuleEntityInPortal
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysPortalId { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public virtual SysModuleEntity? SysModuleEntity { get; set; }

    public virtual SysPortal? SysPortal { get; set; }
}
