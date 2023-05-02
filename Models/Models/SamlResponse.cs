using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SamlResponse
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Response { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public virtual Contact? Contact { get; set; }
}
