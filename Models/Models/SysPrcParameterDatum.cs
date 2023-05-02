using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysPrcParameterDatum
{
    public Guid Id { get; set; }

    public Guid? ProcessId { get; set; }

    public Guid? ParameterId { get; set; }

    public int ValueType { get; set; }

    public byte[]? Value { get; set; }
}
