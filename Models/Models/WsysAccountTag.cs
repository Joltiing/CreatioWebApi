using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WsysAccountTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SysWsysAccountTagRight> SysWsysAccountTagRights { get; set; } = new List<SysWsysAccountTagRight>();

    public virtual TagType? Type { get; set; }

    public virtual ICollection<WsysAccountInTag> WsysAccountInTags { get; set; } = new List<WsysAccountInTag>();
}
