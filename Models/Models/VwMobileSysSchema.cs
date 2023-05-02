using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwMobileSysSchema
{
    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? Id { get; set; }

    public string Name { get; set; } = null!;
}
