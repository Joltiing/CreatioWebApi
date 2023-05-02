using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class SysLdapsynchUser
{
    public Guid RecordId { get; set; }

    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string Company { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public bool IsActive { get; set; }

    public string FullName { get; set; } = null!;

    public string Dn { get; set; } = null!;

    public Guid? LdapSyncId { get; set; }
}
