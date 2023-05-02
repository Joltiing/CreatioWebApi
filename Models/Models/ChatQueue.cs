using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ChatQueue
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? OperatorRoutingRuleId { get; set; }

    public int SimultaneousChats { get; set; }

    public int ChatTimeout { get; set; }

    public int TimeToWaitInQueue { get; set; }

    public virtual ICollection<Channel> Channels { get; set; } = new List<Channel>();

    public virtual ICollection<ChatQueueOperator> ChatQueueOperators { get; set; } = new List<ChatQueueOperator>();

    public virtual ICollection<OmniChatAction> OmniChatActions { get; set; } = new List<OmniChatAction>();

    public virtual ICollection<OmniChat> OmniChats { get; set; } = new List<OmniChat>();

    public virtual OperatorRoutingRule? OperatorRoutingRule { get; set; }

    public virtual ICollection<SysChatQueueLcz> SysChatQueueLczs { get; set; } = new List<SysChatQueueLcz>();
}
