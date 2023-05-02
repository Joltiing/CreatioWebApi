using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysPackage
{
    public Guid? Id { get; set; }

    public int? CreatedOn { get; set; }

    public int? CreatedById { get; set; }

    public int? ModifiedOn { get; set; }

    public int? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public int ProcessListeners { get; set; }
}
