using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysOrgStructureUnitLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? Name { get; set; }

    public string? FullName { get; set; }

    public virtual OrgStructureUnit? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
