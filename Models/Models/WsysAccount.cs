using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class WsysAccount
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public string Name { get; set; } = null!;

    public Guid? ContactId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Guid? RoleId { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual WsysAccountRole? Role { get; set; }

    public virtual ICollection<SysWsysAccountLcz> SysWsysAccountLczs { get; set; } = new List<SysWsysAccountLcz>();

    public virtual ICollection<WsysAccountInTag> WsysAccountInTags { get; set; } = new List<WsysAccountInTag>();
}
