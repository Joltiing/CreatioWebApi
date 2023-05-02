using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OmniChat
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public Guid? StatusId { get; set; }

    public DateTime? CloseDate { get; set; }

    public string ChatPreview { get; set; } = null!;

    public string Conversation { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public Guid? ChannelId { get; set; }

    public Guid? OperatorId { get; set; }

    public int UnprocessedMsgCount { get; set; }

    public DateTime? ChatStartDate { get; set; }

    public DateTime? ChatEndDate { get; set; }

    public int FirstReplyTime { get; set; }

    public DateTime? AcceptDate { get; set; }

    public Guid? DirectedOperatorId { get; set; }

    public int ChatDuration { get; set; }

    public DateTime? CompletionDate { get; set; }

    public Guid? ParentId { get; set; }

    public int LastMessageDirection { get; set; }

    public Guid? QueueId { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual Channel? Channel { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual Contact? Contact { get; set; }

    public virtual SysAdminUnit? DirectedOperator { get; set; }

    public virtual ICollection<OmniChat> InverseParent { get; set; } = new List<OmniChat>();

    public virtual ICollection<OmniChatFile> OmniChatFiles { get; set; } = new List<OmniChatFile>();

    public virtual ICollection<OmniChatInFolder> OmniChatInFolders { get; set; } = new List<OmniChatInFolder>();

    public virtual ICollection<OmniChatInTag> OmniChatInTags { get; set; } = new List<OmniChatInTag>();

    public virtual SysAdminUnit? Operator { get; set; }

    public virtual OmniChat? Parent { get; set; }

    public virtual ChatQueue? Queue { get; set; }

    public virtual OmnichannelChatStatus? Status { get; set; }
}
