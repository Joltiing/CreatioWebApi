using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwAccountDuplicateSearch
{
    public Guid AccountCommunicationId { get; set; }

    public Guid? CommunicationTypeId { get; set; }

    public Guid AccountId { get; set; }

    public DateTime? AccountModifiedOn { get; set; }

    public string? Name { get; set; }

    public string? Number { get; set; }

    public string? SearchNumber { get; set; }

    public string? Web { get; set; }
}
