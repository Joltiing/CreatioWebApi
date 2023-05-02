using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysRecentEntity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? EntityId { get; set; }

    public string EntityCaption { get; set; } = null!;

    public Guid? SysUserId { get; set; }

    public DateTime? UsedOn { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysEntitySchemaUid { get; set; }

    public virtual SysAdminUnit? SysUser { get; set; }
}
