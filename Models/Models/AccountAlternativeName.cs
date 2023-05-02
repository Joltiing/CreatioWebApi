using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountAlternativeName
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid? AccountId { get; set; }

    public int ProcessListeners { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<SysAccountAlternativeNameLcz> SysAccountAlternativeNameLczs { get; set; } = new List<SysAccountAlternativeNameLcz>();

    public virtual ICollection<SysAccountAlternativeNameRight> SysAccountAlternativeNameRights { get; set; } = new List<SysAccountAlternativeNameRight>();
}
