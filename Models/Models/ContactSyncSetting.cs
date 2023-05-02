using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactSyncSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public bool ImportContacts { get; set; }

    public bool ImportContactsAll { get; set; }

    public bool ImportContactsFromFolders { get; set; }

    public bool ImportContactsFromCategories { get; set; }

    public Guid? LinkContactToAccountId { get; set; }

    public bool ExportContactsAll { get; set; }

    public bool ExportContactsSelected { get; set; }

    public bool ExportContactsEmployers { get; set; }

    public bool ExportContactsCustomers { get; set; }

    public bool ExportContactsOwner { get; set; }

    public bool ExportContactsFromGroups { get; set; }

    public Guid? MailboxSyncSettingsId { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public DateTime? LoadContactsFromDate { get; set; }

    public bool ExportContacts { get; set; }

    public string ImportContactsFolders { get; set; } = null!;

    public string ImportContactsCategories { get; set; } = null!;

    public string ExportContactsGroups { get; set; } = null!;

    public virtual LinkContactToAccount? LinkContactToAccount { get; set; }

    public virtual MailboxSyncSetting? MailboxSyncSettings { get; set; }
}
