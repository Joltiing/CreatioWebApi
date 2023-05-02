using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ContactCorrespondence
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string SourceContactId { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public Guid? SourceAccountId { get; set; }

    public Guid? SourceId { get; set; }

    public bool IsDeleted { get; set; }

    public string SocialAccountName { get; set; } = null!;

    public virtual CommunicationType? Source { get; set; }
}
