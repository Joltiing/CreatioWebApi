using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysVwPageTemplateLcz
{
    public Guid Id { get; set; }

    public string? SchemaCaption { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid RecordId { get; set; }

    public Guid? SysCultureId { get; set; }
}
