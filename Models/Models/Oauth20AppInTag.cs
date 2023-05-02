using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class Oauth20AppInTag
{
    public Guid Id { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public int ProcessListeners { get; set; }

    public Guid? TagId { get; set; }

    public Guid? EntityId { get; set; }

    public virtual OauthApplication? Entity { get; set; }

    public virtual ICollection<SysOauth20AppInTagRight> SysOauth20AppInTagRights { get; set; } = new List<SysOauth20AppInTagRight>();

    public virtual Oauth20AppTag? Tag { get; set; }
}
