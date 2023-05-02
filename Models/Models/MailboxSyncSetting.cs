using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailboxSyncSetting
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public Guid? MailServerId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public bool EnableMailSynhronization { get; set; }

    public bool AutomaticallyAddNewEmails { get; set; }

    public bool CyclicallyAddNewEmails { get; set; }

    public int EmailsCyclicallyAddingInterval { get; set; }

    public int ProcessListeners { get; set; }

    public bool IsCustomFlagsNotSuported { get; set; }

    public DateTime? LastSyncDate { get; set; }

    public bool IsShared { get; set; }

    public bool SendEmailsViaThisAccount { get; set; }

    public bool IsDefault { get; set; }

    public bool LoadAllEmailsFromMailBox { get; set; }

    public DateTime? LoadEmailsFromDate { get; set; }

    public string MailboxName { get; set; } = null!;

    public string SenderEmailAddress { get; set; } = null!;

    public bool IsAnonymousAuthentication { get; set; }

    public string SenderDisplayValue { get; set; } = null!;

    public string Signature { get; set; } = null!;

    public bool UseSignature { get; set; }

    public bool ActualizeMessageRelations { get; set; }

    public Guid? ErrorCodeId { get; set; }

    public string LastError { get; set; } = null!;

    public int RetryCounter { get; set; }

    public Guid? OauthTokenStorageId { get; set; }

    public bool SendWebsocketNotifications { get; set; }

    public bool SynchronizationStopped { get; set; }

    public Guid? MailSyncPeriodId { get; set; }

    public bool ExchangeAutoSynchronization { get; set; }

    public int ExchangeSyncInterval { get; set; }

    public int ContactSyncInterval { get; set; }

    public bool ExchangeAutoSyncActivity { get; set; }

    public int SyncDateMinutesOffset { get; set; }

    public bool PersonalMetrics { get; set; }

    public bool MarkEmailsAsSynchronized { get; set; }

    public virtual ICollection<ActivitySyncSetting> ActivitySyncSettings { get; set; } = new List<ActivitySyncSetting>();

    public virtual ICollection<ContactSyncSetting> ContactSyncSettings { get; set; } = new List<ContactSyncSetting>();

    public virtual ICollection<EmailDefRight> EmailDefRights { get; set; } = new List<EmailDefRight>();

    public virtual SyncErrorMessage? ErrorCode { get; set; }

    public virtual MailServer? MailServer { get; set; }

    public virtual MailSyncPeriod? MailSyncPeriod { get; set; }

    public virtual ICollection<MailboxContactFolder> MailboxContactFolders { get; set; } = new List<MailboxContactFolder>();

    public virtual ICollection<MailboxFoldersCorrespondence> MailboxFoldersCorrespondences { get; set; } = new List<MailboxFoldersCorrespondence>();

    public virtual OauthTokenStorage? OauthTokenStorage { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }

    public virtual ICollection<SysMailboxSyncSettingsRight> SysMailboxSyncSettingsRights { get; set; } = new List<SysMailboxSyncSettingsRight>();
}
