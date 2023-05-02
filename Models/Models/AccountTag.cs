using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class AccountTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AccountInTag> AccountInTags { get; set; } = new List<AccountInTag>();

    public virtual ICollection<SysAccountTagRight> SysAccountTagRights { get; set; } = new List<SysAccountTagRight>();

    public virtual TagType? Type { get; set; }
}
