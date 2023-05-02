using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ActivityInTag> ActivityInTags { get; set; } = new List<ActivityInTag>();

    public virtual ICollection<SysActivityTagRight> SysActivityTagRights { get; set; } = new List<SysActivityTagRight>();

    public virtual TagType? Type { get; set; }
}
