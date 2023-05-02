using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwProcessSchemaVersion
{
    public Guid Id { get; set; }

    public bool? IsActiveVersion { get; set; }

    public int? Version { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? ParentUid { get; set; }
}
