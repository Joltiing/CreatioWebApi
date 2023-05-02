using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountBillingInfo
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? AccountId { get; set; }

    public Guid? CountryId { get; set; }

    public string BillingInfo { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public Guid? AccountManagerId { get; set; }

    public Guid? ChiefAccountantId { get; set; }

    public string LegalUnit { get; set; } = null!;

    public virtual Account? Account { get; set; }

    public virtual Contact? AccountManager { get; set; }

    public virtual Contact? ChiefAccountant { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<SysAccountBillingInfoLcz> SysAccountBillingInfoLczs { get; set; } = new List<SysAccountBillingInfoLcz>();
}
