using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Channel
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ProviderId { get; set; }

    public Guid? MsgSettingsId { get; set; }

    public Guid? ChatQueueId { get; set; }

    public string Source { get; set; } = null!;

    public bool IsActive { get; set; }

    public Guid? LanguageId { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual ChatQueue? ChatQueue { get; set; }

    public virtual ICollection<ContactIdentity> ContactIdentities { get; set; } = new List<ContactIdentity>();

    public virtual SysLanguage? Language { get; set; }

    public virtual ICollection<OmniChat> OmniChats { get; set; } = new List<OmniChat>();

    public virtual ChannelProvider? Provider { get; set; }
}
