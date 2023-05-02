using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OptionalFuncSspRole
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? OrgRoleId { get; set; }

    public Guid? FuncRoleId { get; set; }

    public virtual SysAdminUnit? FuncRole { get; set; }

    public virtual SysAdminUnit? OrgRole { get; set; }
}
