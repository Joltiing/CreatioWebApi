using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MessageListener
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string ClassName { get; set; } = null!;

    public virtual ICollection<ListenerByNotifier> ListenerByNotifiers { get; set; } = new List<ListenerByNotifier>();

    public virtual ICollection<SysMessageListenerLcz> SysMessageListenerLczs { get; set; } = new List<SysMessageListenerLcz>();
}
