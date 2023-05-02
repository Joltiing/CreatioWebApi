using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailboxContactFolder
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MailboxSyncSettingsId { get; set; }

    public Guid? ContactFolderId { get; set; }

    public string RemoteFolderId { get; set; } = null!;

    public virtual ContactFolder? ContactFolder { get; set; }

    public virtual MailboxSyncSetting? MailboxSyncSettings { get; set; }
}
