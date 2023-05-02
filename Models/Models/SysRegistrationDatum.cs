using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysRegistrationDatum
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysAdminUnitId { get; set; }

    public Guid? ContactId { get; set; }

    public string UserPassword { get; set; } = null!;

    public int LinkType { get; set; }

    public Guid? LinkId { get; set; }

    public DateTime? LinkExpireDate { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual SysAdminUnit? SysAdminUnit { get; set; }
}
