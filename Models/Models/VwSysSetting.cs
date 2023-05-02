using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSysSetting
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ValueTypeName { get; set; } = null!;

    public Guid? ReferenceSchemaUid { get; set; }

    public bool IsPersonal { get; set; }

    public bool IsCacheable { get; set; }

    public bool IsSspavailable { get; set; }
}
