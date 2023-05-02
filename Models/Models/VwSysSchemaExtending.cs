using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysSchemaExtending
{
    public Guid BaseSchemaId { get; set; }

    public Guid TopExtendingSchemaId { get; set; }

    public string TopExtendingCaption { get; set; } = null!;
}
