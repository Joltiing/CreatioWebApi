using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwContactDuplicateSearch
{
    public Guid ContactCommunicationId { get; set; }

    public Guid ContactId { get; set; }

    public DateTime? ContactModifiedOn { get; set; }

    public Guid? CommunicationTypeId { get; set; }

    public string? Name { get; set; }

    public string? Number { get; set; }

    public string? SearchNumber { get; set; }

    public string? Web { get; set; }
}
