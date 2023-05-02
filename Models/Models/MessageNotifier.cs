using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MessageNotifier
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? SchemaUid { get; set; }

    public string ClassName { get; set; } = null!;

    public Guid? AliasNotifierId { get; set; }

    public string HistoryV2className { get; set; } = null!;

    public virtual MessageNotifier? AliasNotifier { get; set; }

    public virtual ICollection<MessageNotifier> InverseAliasNotifier { get; set; } = new List<MessageNotifier>();

    public virtual ICollection<ListenerByNotifier> ListenerByNotifiers { get; set; } = new List<ListenerByNotifier>();

    public virtual ICollection<MessageNotifierBySection> MessageNotifierBySections { get; set; } = new List<MessageNotifierBySection>();

    public virtual ICollection<SysMessageNotifierLcz> SysMessageNotifierLczs { get; set; } = new List<SysMessageNotifierLcz>();
}
