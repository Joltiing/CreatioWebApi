using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactIdentity
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? ChannelId { get; set; }

    public string ChannelIdentity { get; set; } = null!;

    public bool IsGuestUser { get; set; }

    public virtual Channel? Channel { get; set; }

    public virtual Contact? Contact { get; set; }
}
