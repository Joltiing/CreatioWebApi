using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class EnrchTypeMapping
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string EnrchType { get; set; } = null!;

    public Guid? CommunicationTypeId { get; set; }

    public virtual CommunicationType? CommunicationType { get; set; }
}
