using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class OauthTokenStorage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? SysUserId { get; set; }

    public Guid? OauthAppId { get; set; }

    public string UserAppLogin { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public int ExpiresOn { get; set; }

    public string RefreshToken { get; set; } = null!;

    public virtual ICollection<MailboxSyncSetting> MailboxSyncSettings { get; set; } = new List<MailboxSyncSetting>();

    public virtual OauthApplication? OauthApp { get; set; }

    public virtual SysAdminUnit? SysUser { get; set; }
}
