using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class MailSyncPeriod
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

    public int Number { get; set; }

    public int Position { get; set; }

    public virtual ICollection<ActivitySyncSetting> ActivitySyncSettings { get; set; } = new List<ActivitySyncSetting>();

    public virtual ICollection<MailboxSyncSetting> MailboxSyncSettings { get; set; } = new List<MailboxSyncSetting>();

    public virtual ICollection<SysMailSyncPeriodLcz> SysMailSyncPeriodLczs { get; set; } = new List<SysMailSyncPeriodLcz>();
}
