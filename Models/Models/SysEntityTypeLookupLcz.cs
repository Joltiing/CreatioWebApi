using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysEntityTypeLookupLcz
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? RecordId { get; set; }

    public Guid? SysCultureId { get; set; }

    public string? MenuItemCaption { get; set; }

    public virtual EntityTypeLookup? Record { get; set; }

    public virtual SysCulture? SysCulture { get; set; }
}
