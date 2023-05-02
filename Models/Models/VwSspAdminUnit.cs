using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSspAdminUnit
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? ParentRoleId { get; set; }

    public Guid? ContactId { get; set; }

    public Guid SysAdminUnitTypeId { get; set; }

    public Guid? AccountId { get; set; }

    public bool Active { get; set; }

    public Guid? SysCultureId { get; set; }

    public int ProcessListeners { get; set; }

    public int ConnectionType { get; set; }

    public Guid? PortalAccountId { get; set; }

    public string? LicenseName { get; set; }
}
