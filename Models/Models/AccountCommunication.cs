using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountCommunication
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public Guid? CommunicationTypeId { get; set; }

    public string Number { get; set; } = null!;

    public Guid? AccountId { get; set; }

    public int Position { get; set; }

    public string SocialMediaId { get; set; } = null!;

    public string SearchNumber { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public bool Primary { get; set; }

    public virtual Account? Account { get; set; }

    public virtual CommunicationType? CommunicationType { get; set; }
}
