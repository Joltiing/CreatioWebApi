using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Unit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<SysUnitLcz> SysUnitLczs { get; set; } = new List<SysUnitLcz>();
}
