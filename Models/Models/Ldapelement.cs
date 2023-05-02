using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Ldapelement
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public string LdapentryId { get; set; } = null!;

    public string LdapentryDn { get; set; } = null!;

    public int Type { get; set; }

    public string FullName { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<LdapuserInLdapgroup> LdapuserInLdapgroupLdapgroups { get; set; } = new List<LdapuserInLdapgroup>();

    public virtual ICollection<LdapuserInLdapgroup> LdapuserInLdapgroupLdapusers { get; set; } = new List<LdapuserInLdapgroup>();

    public virtual ICollection<SysAdminUnit> SysAdminUnits { get; set; } = new List<SysAdminUnit>();
}
