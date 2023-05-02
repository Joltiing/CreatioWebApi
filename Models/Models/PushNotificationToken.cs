using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PushNotificationToken
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Token { get; set; } = null!;

    public Guid? ServiceId { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public virtual PushNotificationService? Service { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
