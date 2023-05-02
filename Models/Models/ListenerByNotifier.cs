using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ListenerByNotifier
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MessageNotifierId { get; set; }

    public Guid? MessageListenerId { get; set; }

    public string NotifierConnectionColumn { get; set; } = null!;

    public virtual MessageListener? MessageListener { get; set; }

    public virtual MessageNotifier? MessageNotifier { get; set; }
}
