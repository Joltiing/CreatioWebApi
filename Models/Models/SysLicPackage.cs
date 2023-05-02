using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLicPackage
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string PublicKey { get; set; } = null!;

    public string Operations { get; set; } = null!;

    public string Key { get; set; } = null!;

    public bool UseUserAssociation { get; set; }

    public bool IsSsp { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<SysLicUser> SysLicUsers { get; set; } = new List<SysLicUser>();

    public virtual ICollection<SysLic> SysLics { get; set; } = new List<SysLic>();
}
