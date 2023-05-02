using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountOwnership
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? CountryId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<SysAccountOwnershipLcz> SysAccountOwnershipLczs { get; set; } = new List<SysAccountOwnershipLcz>();
}
