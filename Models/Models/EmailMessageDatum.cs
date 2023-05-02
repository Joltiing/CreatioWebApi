using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EmailMessageDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ActivityId { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? RoleId { get; set; }

    public string Headers { get; set; } = null!;

    public bool IsNeedProcess { get; set; }

    public Guid? MailboxSyncSettings { get; set; }

    public string MessageId { get; set; } = null!;

    public string InReplyTo { get; set; } = null!;

    public Guid? ParentMessageId { get; set; }

    public string SyncSessionId { get; set; } = null!;

    public Guid? ExchangeThreadId { get; set; }

    public int ExchangeThreadPosition { get; set; }

    public string References { get; set; } = null!;

    public Guid? ConversationId { get; set; }

    public DateTime? SendDate { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual Contact? Owner { get; set; }

    public virtual ActivityParticipantRole? Role { get; set; }
}
