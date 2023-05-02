using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContentBlockInTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual ContentBlock? Entity { get; set; }

    public virtual ICollection<SysContentBlockInTagRight> SysContentBlockInTagRights { get; set; } = new List<SysContentBlockInTagRight>();

    public virtual ContentBlockTag? Tag { get; set; }
}
