using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ChannelProvider
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? IconId { get; set; }

    public string PageUrl { get; set; } = null!;

    public virtual ICollection<Channel> Channels { get; set; } = new List<Channel>();

    public virtual SysImage? Icon { get; set; }

    public virtual ICollection<SysChannelProviderLcz> SysChannelProviderLczs { get; set; } = new List<SysChannelProviderLcz>();
}
