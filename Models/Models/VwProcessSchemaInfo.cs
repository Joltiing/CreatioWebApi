using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwProcessSchemaInfo
{
    public Guid Id { get; set; }

    public int IsActiveVersionSchemaProperty { get; set; }

    public int IsActiveVersionUserProperty { get; set; }

    public int? PackageLevel { get; set; }

    public string PackageName { get; set; } = null!;

    public Guid? ParentId { get; set; }

    public int? Version { get; set; }

    public string SchemaName { get; set; } = null!;
}
