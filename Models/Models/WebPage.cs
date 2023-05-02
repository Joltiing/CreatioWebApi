using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WebPage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string Url { get; set; } = null!;

    public virtual ICollection<SysWebPageLcz> SysWebPageLczs { get; set; } = new List<SysWebPageLcz>();

    public virtual ICollection<TouchAction> TouchActions { get; set; } = new List<TouchAction>();
}
