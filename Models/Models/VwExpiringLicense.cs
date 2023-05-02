using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwExpiringLicense
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string LicPackageName { get; set; } = null!;

    public int Count { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int? LicUserCount { get; set; }
}
