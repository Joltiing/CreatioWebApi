using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class CtisearchResult
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? ContactId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? SearchId { get; set; }

    public Guid? CommunicationTypeId { get; set; }

    public string Number { get; set; } = null!;

    public virtual Account? Account { get; set; }

    public virtual CommunicationType? CommunicationType { get; set; }

    public virtual Contact? Contact { get; set; }
}
