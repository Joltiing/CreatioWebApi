using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntitySchemaReferenceLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? ColumnCaption { get; set; }

    public virtual SysEntitySchemaReference? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
