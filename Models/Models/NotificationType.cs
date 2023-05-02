using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class NotificationType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<NotificationsSetting> NotificationsSettings { get; set; } = new List<NotificationsSetting>();

    public virtual ICollection<Reminding> Remindings { get; set; } = new List<Reminding>();
}
