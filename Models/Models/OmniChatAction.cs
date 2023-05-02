using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OmniChatAction
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Caption { get; set; } = null!;

    public Guid? ProcessSchemaId { get; set; }

    public Guid? ChatQueueId { get; set; }

    public virtual ChatQueue? ChatQueue { get; set; }

    public virtual ICollection<SysOmniChatActionLcz> SysOmniChatActionLczs { get; set; } = new List<SysOmniChatActionLcz>();
}
