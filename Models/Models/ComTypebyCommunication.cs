using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ComTypebyCommunication
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? CommunicationTypeId { get; set; }

    public Guid? CommunicationId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Communication? Communication { get; set; }

    public virtual CommunicationType? CommunicationType { get; set; }
}
