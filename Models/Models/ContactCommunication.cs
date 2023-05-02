using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactCommunication
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? CommunicationTypeId { get; set; }

    public string Number { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public int Position { get; set; }

    public string SocialMediaId { get; set; } = null!;

    public string SearchNumber { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public bool IsCreatedBySynchronization { get; set; }

    public string ExternalCommunicationType { get; set; } = null!;

    public virtual CommunicationType? CommunicationType { get; set; }

    public virtual Contact? Contact { get; set; }
}
