using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysRepository
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public bool IsActive { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysPackage> SysPackages { get; set; } = new List<SysPackage>();

    public virtual ICollection<SysRepositoryUser> SysRepositoryUsers { get; set; } = new List<SysRepositoryUser>();
}
