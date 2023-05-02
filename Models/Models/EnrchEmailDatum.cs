using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EnrchEmailDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string JsonData { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<EnrchTextEntity> EnrchTextEntities { get; set; } = new List<EnrchTextEntity>();
}
