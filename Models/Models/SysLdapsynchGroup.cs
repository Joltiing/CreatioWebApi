using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLdapsynchGroup
{
    public Guid RecordId { get; set; }

    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Dn { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public Guid? LdapSyncId { get; set; }
}
