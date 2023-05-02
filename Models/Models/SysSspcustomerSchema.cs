using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSspcustomerSchema
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? SysSchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
