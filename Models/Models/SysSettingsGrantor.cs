using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSettingsGrantor
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSettingsId { get; set; }

    public Guid? SysAdminUnitId { get; set; }
}
