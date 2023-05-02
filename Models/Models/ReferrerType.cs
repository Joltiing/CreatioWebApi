using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ReferrerType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysReferrerTypeLcz> SysReferrerTypeLczs { get; set; } = new List<SysReferrerTypeLcz>();

    public virtual ICollection<Touch> Touches { get; set; } = new List<Touch>();
}
