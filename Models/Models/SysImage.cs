using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysImage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? UploadedOn { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? Data { get; set; }

    public string MimeType { get; set; } = null!;

    public bool HasRef { get; set; }

    public byte[]? PreviewData { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<CallDirection> CallDirections { get; set; } = new List<CallDirection>();

    public virtual ICollection<ChannelProvider> ChannelProviders { get; set; } = new List<ChannelProvider>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<ContentBlock> ContentBlocks { get; set; } = new List<ContentBlock>();

    public virtual ICollection<ContentUserBlock> ContentUserBlocks { get; set; } = new List<ContentUserBlock>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EsnnotificationType> EsnnotificationTypes { get; set; } = new List<EsnnotificationType>();

    public virtual ICollection<FolderType> FolderTypes { get; set; } = new List<FolderType>();

    public virtual ICollection<LeadType> LeadTypes { get; set; } = new List<LeadType>();

    public virtual ICollection<MailServer> MailServers { get; set; } = new List<MailServer>();

    public virtual ICollection<MessagePublisher> MessagePublishers { get; set; } = new List<MessagePublisher>();

    public virtual ICollection<MultiLookupImage> MultiLookupImages { get; set; } = new List<MultiLookupImage>();

    public virtual ICollection<NotificationsSetting> NotificationsSettings { get; set; } = new List<NotificationsSetting>();

    public virtual ICollection<OauthApplication> OauthApplications { get; set; } = new List<OauthApplication>();

    public virtual ICollection<PageTemplate> PageTemplates { get; set; } = new List<PageTemplate>();

    public virtual ICollection<PortalSysModule> PortalSysModuleImage32s { get; set; } = new List<PortalSysModule>();

    public virtual ICollection<PortalSysModule> PortalSysModuleLogos { get; set; } = new List<PortalSysModule>();

    public virtual ICollection<SocialChannel> SocialChannels { get; set; } = new List<SocialChannel>();

    public virtual ICollection<SysAppTemplate> SysAppTemplates { get; set; } = new List<SysAppTemplate>();

    public virtual ICollection<SysChartSeriesKind> SysChartSeriesKinds { get; set; } = new List<SysChartSeriesKind>();

    public virtual ICollection<SysCulture> SysCultures { get; set; } = new List<SysCulture>();

    public virtual ICollection<SysInstalledApp> SysInstalledApps { get; set; } = new List<SysInstalledApp>();

    public virtual ICollection<SysModuleAnalyticsReport> SysModuleAnalyticsReports { get; set; } = new List<SysModuleAnalyticsReport>();

    public virtual ICollection<SysModule> SysModuleImage32s { get; set; } = new List<SysModule>();

    public virtual ICollection<SysModule> SysModuleLogos { get; set; } = new List<SysModule>();

    public virtual ICollection<SysMsgUserStateReason> SysMsgUserStateReasons { get; set; } = new List<SysMsgUserStateReason>();

    public virtual ICollection<SysMsgUserState> SysMsgUserStates { get; set; } = new List<SysMsgUserState>();

    public virtual ICollection<SysOperationResult> SysOperationResults { get; set; } = new List<SysOperationResult>();

    public virtual ICollection<SysProcessUserTask> SysProcessUserTasks { get; set; } = new List<SysProcessUserTask>();
}
