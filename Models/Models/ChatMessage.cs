using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ChatMessage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string MessageDirection { get; set; } = null!;

    public Guid? ChannelId { get; set; }

    public Guid? OmniChatId { get; set; }

    public string Source { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Recipient { get; set; } = null!;

    public string Sender { get; set; } = null!;

    public string Timestamp { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public virtual Channel? Channel { get; set; }

    public virtual OmniChat? OmniChat { get; set; }
}
