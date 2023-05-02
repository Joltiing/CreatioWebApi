using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysMsgUserSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? UserId { get; set; }

    public string ConnectionParams { get; set; } = null!;

    public Guid? SysMsgLibId { get; set; }

    public virtual SysMsgLib? SysMsgLib { get; set; }

    public virtual SysAdminUnit? User { get; set; }
}
