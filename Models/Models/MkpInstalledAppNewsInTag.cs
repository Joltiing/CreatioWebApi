using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MkpInstalledAppNewsInTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual MkpInstalledAppNews? Entity { get; set; }

    public virtual ICollection<SysMkpInstAppNewsInTagRight> SysMkpInstAppNewsInTagRights { get; set; } = new List<SysMkpInstAppNewsInTagRight>();

    public virtual MkpInstalledAppNewsTag? Tag { get; set; }
}
