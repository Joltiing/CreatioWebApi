using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailServerDomain
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Domain { get; set; } = null!;

    public Guid? MailServerId { get; set; }

    public virtual MailServer? MailServer { get; set; }
}
