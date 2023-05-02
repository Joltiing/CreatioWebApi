using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAccountCleanDataValue
{
    public Guid Id { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Name { get; set; }
}
