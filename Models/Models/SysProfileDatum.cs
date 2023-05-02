using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysProfileDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysUserId { get; set; }

    public Guid? ObjectId { get; set; }

    public string Key { get; set; } = null!;

    public byte[]? ObjectData { get; set; }

    public byte[]? ObjectDifference { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? SysCultureId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual SysCulture? SysCulture { get; set; }

    public virtual SysAdminUnit? SysUser { get; set; }
}
