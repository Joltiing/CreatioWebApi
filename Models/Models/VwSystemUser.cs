using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSystemUser
{
    public Guid Id { get; set; }

    public Guid ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public int ConnectionType { get; set; }
}
