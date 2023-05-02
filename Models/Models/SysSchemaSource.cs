using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSchemaSource
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? Source { get; set; }

    public Guid? SysSchemaId { get; set; }
}
