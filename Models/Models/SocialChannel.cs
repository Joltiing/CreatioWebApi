using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SocialChannel
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Title { get; set; } = null!;

    public Guid? ImageId { get; set; }

    public string Description { get; set; } = null!;

    public bool PublisherRightKind { get; set; }

    public string Color { get; set; } = null!;

    public virtual SysImage? Image { get; set; }

    public virtual ICollection<SocialChannelInFolder> SocialChannelInFolders { get; set; } = new List<SocialChannelInFolder>();

    public virtual ICollection<SocialChannelInTag> SocialChannelInTags { get; set; } = new List<SocialChannelInTag>();

    public virtual ICollection<SocialChannelPublisher> SocialChannelPublishers { get; set; } = new List<SocialChannelPublisher>();

    public virtual ICollection<SysSocialChannelLcz> SysSocialChannelLczs { get; set; } = new List<SysSocialChannelLcz>();

    public virtual ICollection<SysSocialChannelRight> SysSocialChannelRights { get; set; } = new List<SysSocialChannelRight>();
}
