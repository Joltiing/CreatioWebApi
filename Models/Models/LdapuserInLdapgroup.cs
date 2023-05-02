using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class LdapuserInLdapgroup
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? LdapuserId { get; set; }

    public Guid? LdapgroupId { get; set; }

    public virtual Ldapelement? Ldapgroup { get; set; }

    public virtual Ldapelement? Ldapuser { get; set; }
}
