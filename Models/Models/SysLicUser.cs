using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLicUser
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysLicPackageId { get; set; }

    public Guid? SysUserId { get; set; }

    public bool Active { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysLicPackage? SysLicPackage { get; set; }

    public virtual SysAdminUnit? SysUser { get; set; }
}
