using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysSchemaContent
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Code { get; set; } = null!;

    public int ContentType { get; set; }

    public byte[]? Content { get; set; }

    public Guid? SysSchemaId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual SysSchema? SysSchema { get; set; }
}
