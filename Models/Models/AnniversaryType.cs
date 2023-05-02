using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AnniversaryType
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProcessListeners { get; set; }

    public virtual ICollection<AccountAnniversary> AccountAnniversaries { get; set; } = new List<AccountAnniversary>();

    public virtual ICollection<ContactAnniversary> ContactAnniversaries { get; set; } = new List<ContactAnniversary>();

    public virtual ICollection<SysAnniversaryTypeLcz> SysAnniversaryTypeLczs { get; set; } = new List<SysAnniversaryTypeLcz>();
}
