using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialChannelTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SocialChannelInTag> SocialChannelInTags { get; set; } = new List<SocialChannelInTag>();

    public virtual ICollection<SysSocialChannelTagRight> SysSocialChannelTagRights { get; set; } = new List<SysSocialChannelTagRight>();

    public virtual TagType? Type { get; set; }
}
