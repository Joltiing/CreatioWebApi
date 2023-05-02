using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwContactNoCommunicationDuplicateSearch
{
    public Guid ContactId { get; set; }

    public DateTime? ContactModifiedOn { get; set; }

    public string? Name { get; set; }
}
