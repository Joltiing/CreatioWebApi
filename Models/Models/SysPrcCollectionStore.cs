using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcCollectionStore
{
    public Guid Id { get; set; }

    public Guid? ProcessId { get; set; }

    public string ParameterPath { get; set; } = null!;

    public Guid? ContextId { get; set; }

    public int Index { get; set; }

    public byte[]? Value { get; set; }
}
