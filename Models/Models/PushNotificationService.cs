using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class PushNotificationService
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public string Settings { get; set; } = null!;

    public bool Enabled { get; set; }

    public string ClassName { get; set; } = null!;

    public virtual ICollection<PushNotificationToken> PushNotificationTokens { get; set; } = new List<PushNotificationToken>();
}
