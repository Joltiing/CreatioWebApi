using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysAccountEmployeesNumberLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual AccountEmployeesNumber? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
