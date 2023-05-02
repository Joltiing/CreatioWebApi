using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ActivityPriority
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public byte[]? Img { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<SysActivityPriorityLcz> SysActivityPriorityLczs { get; set; } = new List<SysActivityPriorityLcz>();
}
