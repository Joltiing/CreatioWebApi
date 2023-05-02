using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SyncErrorMessage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string UserMessage { get; set; } = null!;

    public string Action { get; set; } = null!;

    public virtual ICollection<MailboxSyncSetting> MailboxSyncSettings { get; set; } = new List<MailboxSyncSetting>();

    public virtual ICollection<SyncErrorHandler> SyncErrorHandlers { get; set; } = new List<SyncErrorHandler>();

    public virtual ICollection<SysSyncErrorMessageLcz> SysSyncErrorMessageLczs { get; set; } = new List<SysSyncErrorMessageLcz>();
}
