using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OmnichannelMessage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public long? Timestamp { get; set; }

    public string Sender { get; set; } = null!;

    public string Recipient { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string MessageDirection { get; set; } = null!;

    public Guid? ChatId { get; set; }

    public Guid? ChannelId { get; set; }

    public string MessageType { get; set; } = null!;

    public string Attachments { get; set; } = null!;

    public bool IsBotMessage { get; set; }

    public bool IsStandBy { get; set; }
}
