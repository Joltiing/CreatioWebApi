using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcParameterPath
{
    public Guid Id { get; set; }

    public Guid? SchemaId { get; set; }

    public string Path { get; set; } = null!;
}
