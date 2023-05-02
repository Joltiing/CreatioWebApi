using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LocationHistory
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public DateTime? Date { get; set; }

    public string Longitude { get; set; } = null!;

    public string Latitude { get; set; } = null!;

    public bool IsApproximate { get; set; }

    public Guid? ContactId { get; set; }

    public virtual Contact? Contact { get; set; }
}
