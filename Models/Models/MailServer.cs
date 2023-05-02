using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailServer
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int Port { get; set; }

    public bool UseSsl { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? EmailProtocolId { get; set; }

    public bool AllowEmailDownloading { get; set; }

    public bool AllowEmailSending { get; set; }

    public string SmtpserverAddress { get; set; } = null!;

    public int Smtpport { get; set; }

    public int SmtpserverTimeout { get; set; }

    public bool UseSslforSending { get; set; }

    public bool IsStartTls { get; set; }

    public bool UseLogin { get; set; }

    public Guid? LogoId { get; set; }

    public bool UseUserNameAsLogin { get; set; }

    public bool UseEmailAddressAsLogin { get; set; }

    public string Strategy { get; set; } = null!;

    public Guid? OauthApplicationId { get; set; }

    public string ExchangeEmailAddress { get; set; } = null!;

    public bool IsExchengeAutodiscover { get; set; }

    public Guid? TypeId { get; set; }

    public int SubscriptionTtl { get; set; }

    public Guid? SmtpSecureOptionId { get; set; }

    public Guid? ImapSecureOptionId { get; set; }

    public virtual EmailProtocol? EmailProtocol { get; set; }

    public virtual MailSecureOption? ImapSecureOption { get; set; }

    public virtual SysImage? Logo { get; set; }

    public virtual ICollection<MailServerDomain> MailServerDomains { get; set; } = new List<MailServerDomain>();

    public virtual ICollection<MailboxSyncSetting> MailboxSyncSettings { get; set; } = new List<MailboxSyncSetting>();

    public virtual OauthApplication? OauthApplication { get; set; }

    public virtual MailSecureOption? SmtpSecureOption { get; set; }

    public virtual ICollection<SysMailServerLcz> SysMailServerLczs { get; set; } = new List<SysMailServerLcz>();

    public virtual MailServerType? Type { get; set; }
}
