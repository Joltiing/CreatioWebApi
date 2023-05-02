using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Mlerror
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Text { get; set; } = null!;

    public string Pattern { get; set; } = null!;

    public virtual ICollection<Mlmodel> Mlmodels { get; set; } = new List<Mlmodel>();

    public virtual ICollection<SysMlerrorLcz> SysMlerrorLczs { get; set; } = new List<SysMlerrorLcz>();
}
