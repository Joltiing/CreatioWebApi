using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysRepositoryUser
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Guid? SysRepositoryId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual SysRepository? SysRepository { get; set; }
}
