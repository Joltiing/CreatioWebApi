using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSchemaUserProperty
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public Guid? SysSchemaId { get; set; }
}
