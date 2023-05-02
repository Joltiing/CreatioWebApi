using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OmniChatTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<OmniChatInTag> OmniChatInTags { get; set; } = new List<OmniChatInTag>();

    public virtual ICollection<SysOmniChatTagRight> SysOmniChatTagRights { get; set; } = new List<SysOmniChatTagRight>();

    public virtual TagType? Type { get; set; }
}
