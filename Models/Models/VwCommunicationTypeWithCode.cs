using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwCommunicationTypeWithCode
{
    public Guid Id { get; set; }

    public bool UseforAccounts { get; set; }

    public bool UseforContacts { get; set; }

    public string? Code { get; set; }
}
