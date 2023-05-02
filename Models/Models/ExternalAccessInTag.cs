using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class ExternalAccessInTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual ExternalAccess? Entity { get; set; }

    public virtual ICollection<SysExternalAccessInTagRight> SysExternalAccessInTagRights { get; set; } = new List<SysExternalAccessInTagRight>();

    public virtual ExternalAccessTag? Tag { get; set; }
}
