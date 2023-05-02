using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailboxFoldersCorrespondence
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? MailboxId { get; set; }

    public Guid? ActivityFolderId { get; set; }

    public string FolderPath { get; set; } = null!;

    public string Uid { get; set; } = null!;

    public string UidValidity { get; set; } = null!;

    public virtual ActivityFolder? ActivityFolder { get; set; }

    public virtual MailboxSyncSetting? Mailbox { get; set; }
}
