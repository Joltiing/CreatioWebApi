using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContentBlockTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ContentBlockInTag> ContentBlockInTags { get; set; } = new List<ContentBlockInTag>();

    public virtual ICollection<SysContentBlockTagRight> SysContentBlockTagRights { get; set; } = new List<SysContentBlockTagRight>();

    public virtual TagType? Type { get; set; }
}
